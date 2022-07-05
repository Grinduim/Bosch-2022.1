import styled from "styled-components";
import { primaryColor,secondaryColor } from "../../config/colors";
import { CollorsMC } from "../../config/colors";

export const Footer = styled.nav `
    .container-footer{
        border-top: 2px solid ${CollorsMC.red};
        padding-top:1em;
        display: flex;
        justify-content: space-around;
        align-items: center;
        position: fixed;
        bottom: 0;
        width: 100vw;
        margin-bottom: 15px;
    }
    a{
        color: black;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: row;
        gap: 5px;
    }

    
`;