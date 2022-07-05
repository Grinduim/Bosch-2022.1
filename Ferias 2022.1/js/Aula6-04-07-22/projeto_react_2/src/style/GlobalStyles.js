import styled, { createGlobalStyle } from "styled-components";
import { darkColor, secondaryColor, CollorsMC } from "../config/colors";
import 'react-toastify/dist/ReactToastify.css';

export default createGlobalStyle`
    * {
    margin: 0;
    padding: 0;
    outline: 0;
    box-sizing: border-box;
    }

    body {
    font-family: sans-serif;
    background: ${CollorsMC.White};
    }

    html, border-style, #root {
    height: 100%;
    }

    button {
    cursor: pointer;
    }

    a {
    text-decoration: none;
    }

    ul {
    list-style: none;
    }
 `;

export const Container = styled.section`
  max-width: 75%;
  background: ${secondaryColor};
  margin: 30px auto;
  padding: 30px;
  border-radius: 4px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
`;
