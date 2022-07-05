import React from "react";
import { toast } from "react-toastify";
import { Navigate, Outlet, useLocation } from "react-router-dom";
import PropTypes from "prop-types";

export default function PrivateRoute(isClosed) {
  const isLoggedId = false;
  let location = useLocation();
  if (isClosed.isClosed && !isLoggedId) {
    toast.error("Acesso negado");
    return <Navigate to="/login" state={{ from: location }} />;
  }
  toast.success("Acesso liberado");
  return <Outlet />;
}

PrivateRoute.defaultProps = {
  isClosed: false,
};

PrivateRoute.propTypes = {
  isClosed: PropTypes.bool,
};
