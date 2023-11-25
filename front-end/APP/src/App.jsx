import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";

import Home from "./pages/Homapage/Home.jsx";
import About from "./pages/About/About.jsx";
import AppLayout from "./pages/AppLayout.jsx";
import PageNotFound from "./components/PageNotFound.jsx";
import Login from "./components/authComponents/Login.jsx";
import Register from "./components/authComponents/Register.jsx";
import Auth from "./pages/Auth.jsx";
import UserProfile from "./components/UserProfile.jsx";
import UserInfo from "./components/dashComponents/UserInfo.jsx";
import CreateBike from "./components/createComponents/CreateBike.jsx";
import ForgottenPassword from "./components/authComponents/ForgottenPassword.jsx";
import Cart from "./components/dashComponents/Cart.jsx";
import { GlobalUser } from "./context/GlobalUserProvider.jsx";
import ManagerOrders from "./components/dashComponents/managerComponents/ManagerOrders.jsx";
import WorkerOrders from "./components/dashComponents/workerComponents/WorkerOrders.jsx";
import WorkerFinished from "./components/dashComponents/workerComponents/WorkerFinished.jsx";

function App() {
  return (
    <GlobalUser>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="about" element={<About />} />

          <Route path="profile" element={<UserProfile />}>
            <Route index element={<Navigate replace to="info" />} />
            <Route path="info" element={<UserInfo />} />
            <Route path={"cart"} element={<Cart />} />
            <Route path="workerOrders" element={<WorkerOrders />} />
            <Route path={"finished"} element={<WorkerFinished />} />
            <Route path={"managerOrders"} element={<ManagerOrders />} />
          </Route>

          <Route path="app" element={<AppLayout />}>
            <Route index element={<Navigate replace to="create" />} />
            <Route path={"create"} element={<CreateBike />} />
          </Route>

          <Route path="auth" element={<Auth />}>
            <Route index element={<Navigate replace to="login" />} />
            <Route path="login" element={<Login />} />
            <Route path="register" element={<Register />} />
            <Route path="forgotten-password" element={<ForgottenPassword />} />
          </Route>

          <Route path="*" element={<PageNotFound />} />
        </Routes>
      </BrowserRouter>
    </GlobalUser>
  );
}

export default App;
