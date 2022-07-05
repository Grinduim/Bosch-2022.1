import React from "react";
import { Routes, Route } from "react-router-dom";
import PrivateRoute from "./PrivateRoute";

import Login from "../pages/login";
import Page404 from '../pages/Error';

export default function Urls() {
  return (
    <>
      <Routes>
        <Route exact path="/" element={<PrivateRoute />}>
          <Route exact path="/" element={<Login />} />
        </Route>
        <Route path="*" element={<Page404 />} />
      </Routes>
    </>
  );
}
