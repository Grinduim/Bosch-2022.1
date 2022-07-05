import styled from "styled-components";
import { secondaryColor, primaryColor } from "../../config/colors";
export const Nav = styled.nav`
  background: ${primaryColor};
  padding: 20px;
  display: flex;
  align-content: center;
  justify-content: right;

  a {
    color: ${secondaryColor};
    margin: 0 10px 0 0;
    font-weight: bold;
  }
`;
