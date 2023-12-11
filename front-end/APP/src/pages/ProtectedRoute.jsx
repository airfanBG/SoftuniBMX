import { useNavigate } from "react-router-dom";
import { useAuth } from "../context/AuthContext.jsx";
import { useEffect } from "react";

function ProtectedRoute({ children }) {
  const { isAuthenticated } = useAuth();
  const navigate = useNavigate();

  useEffect(
    function () {
      if (!isAuthenticated) navigate("/auth/login");
    },
    [isAuthenticated, navigate]
  );

  return isAuthenticated ? children : null;
}
export default ProtectedRoute;
