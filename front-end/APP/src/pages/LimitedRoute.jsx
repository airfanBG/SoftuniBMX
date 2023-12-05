import { useNavigate } from "react-router-dom";
import { useAuth } from "../context/AuthContext.jsx";
import { useEffect } from "react";

function LimitedRoute({ children }) {
  const { isAuthenticated, userAuth } = useAuth();
  const navigate = useNavigate();

  useEffect(
    function () {
      if (!isAuthenticated) {
        navigate("/auth/login");
      } else if (isAuthenticated && userAuth.role !== "user") {
        navigate("/", { replace: true });
      }
    },
    [isAuthenticated, navigate, userAuth.role]
  );

  return isAuthenticated ? children : null;
}
export default LimitedRoute;
