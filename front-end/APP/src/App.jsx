import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import { Suspense, lazy } from "react";

import Auth from "./pages/Auth.jsx";
// import { GlobalUser, OrdersManager } from "./context/GlobalUserProvider.jsx";
import { GlobalUser } from "./context/GlobalUserProvider.jsx";
import { AuthProvider } from "./context/AuthContext.jsx";
import ProtectedRoute from "./pages/ProtectedRoute.jsx";
import LimitedRoute from "./pages/LimitedRoute.jsx";

import ForgottenPassword from "./components/authComponents/ForgottenPassword.jsx";
import Register from "./components/authComponents/Register.jsx";
import Cart from "./components/dashComponents/Cart.jsx";
import ManagerOrders from "./components/dashComponents/managerComponents/ManagerOrders.jsx";
import WorkerOrders from "./components/dashComponents/workerComponents/WorkerOrders.jsx";
import WorkerFinished from "./components/dashComponents/workerComponents/WorkerFinished.jsx";
import UserInfo from "./components/dashComponents/userComponents/UserInfo.jsx";
import EmployersList from "./components/dashComponents/managerComponents/EmployersList.jsx";
import AddMember from "./components/dashComponents/managerComponents/AddMember.jsx";
import InProgress from "./components/dashComponents/managerComponents/InProgress.jsx";
import QControlOrders from "./components/dashComponents/qControlComponents/QControlOrders.jsx";
import UserTrackOrder from "./components/dashComponents/userComponents/UserTrackOrder.jsx";
import UserHomeScreenSelection from "./components/dashComponents/userComponents/UserHomeScreenSelection.jsx";
import ComponentScaffold from "./components/dashComponents/userComponents/ComponentScaffold.jsx";
import UserArchive from "./components/dashComponents/userComponents/UserArchive.jsx";
import LoaderWheel from "./components/LoaderWheel.jsx";
import { ErrorProvider } from "./context/ErrorContext.jsx";
import ManagerRejected from "./components/dashComponents/managerComponents/ManagerRejected.jsx";
import ManagerFinished from "./components/dashComponents/managerComponents/ManagerFinished.jsx";

// LAZY LOADING
const CreateBike = lazy(() =>
  import("./components/createComponents/CreateBike.jsx")
);
const UserProfile = lazy(() => import("./components/UserProfile.jsx"));
const Login = lazy(() => import("./components/authComponents/Login.jsx"));
const Home = lazy(() => import("./pages/Homapage/Home.jsx"));
const About = lazy(() => import("./pages/About/About.jsx"));
const AppLayout = lazy(() => import("./pages/AppLayout.jsx"));
const PageNotFound = lazy(() => import("./components/PageNotFound.jsx"));

function App() {
  return (
    <AuthProvider>
      <GlobalUser>
        <ErrorProvider>
          <BrowserRouter>
            <Suspense fallback={<LoaderWheel />}>
              <Routes>
                <Route path="/" element={<Home />} />
                <Route path="about" element={<About />} />
                <Route
                  path="profile"
                  element={
                    <ProtectedRoute>
                      <UserProfile />
                    </ProtectedRoute>
                  }
                >
                  <Route index element={<Navigate replace to="info" />} />
                  <Route path="info" element={<UserInfo />} />
                  <Route path={"cart"} element={<Cart />} />
                  <Route path={"user-ready"} element={<ComponentScaffold />} />
                  <Route
                    path={"user-in-progress"}
                    element={<UserTrackOrder />}
                  />
                  <Route path={"user-archive"} element={<UserArchive />} />

                  <Route
                    path={"get-stock"}
                    element={<UserHomeScreenSelection />}
                  />
                  <Route path="worker-orders" element={<WorkerOrders />} />
                  <Route path={"finished"} element={<WorkerFinished />} />
                  <Route path={"managerOrders"} element={<ManagerOrders />} />
                  <Route
                    path={"manager-in-progress"}
                    element={<InProgress />}
                  />
                  <Route
                    path={"manager-ready"}
                    element={<ComponentScaffold />}
                  />
                  <Route
                    path={"manager-rejected"}
                    element={<ManagerRejected />}
                  />
                  <Route
                    path={"manager-finished"}
                    element={<ManagerFinished />}
                  />
                  <Route path={"employers"} element={<EmployersList />} />
                  <Route path={"statistic"} />
                  <Route path={"add-member"} element={<AddMember />} />
                  <Route
                    path={"q-control-orders"}
                    element={<QControlOrders />}
                  />
                </Route>
                <Route
                  path="app"
                  element={
                    <LimitedRoute>
                      <AppLayout />
                    </LimitedRoute>
                  }
                >
                  <Route index element={<Navigate replace to="create" />} />
                  <Route path={"create"} element={<CreateBike />} />
                </Route>
                <Route path="auth" element={<Auth />}>
                  <Route index element={<Navigate replace to="login" />} />
                  <Route path="login" element={<Login />} />
                  <Route path="register" element={<Register />} />
                  <Route
                    path="forgotten-password"
                    element={<ForgottenPassword />}
                  />
                </Route>
                <Route path="*" element={<PageNotFound />} />
              </Routes>
            </Suspense>
          </BrowserRouter>
        </ErrorProvider>
      </GlobalUser>
    </AuthProvider>
  );
}

export default App;
