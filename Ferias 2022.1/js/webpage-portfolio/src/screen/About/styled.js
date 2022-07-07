import styled from "styled-components";
import { Colors } from "../../config/colors";
import { TitleFont } from "../../config/font";

export const AboutStyled = styled.section`
    width: 100%;
    background-color: ${Colors.Black};
    color: white;
    display: flex;
    align-items:center;
    gap:1em;
    flex-direction: column;
    h1{
        font-family: ${TitleFont};
        font-size: 2.5em;
        letter-spacing: 4px;
    }

    p{  
        color: whitesmoke;
        font-weight: 100;
        width: 45%;
        font-size: 1.3em;
        border-radius: 10px;
        border-width: 3px;
        border-style: solid;
        border-image: 
        linear-gradient(
        to bottom, 
        red, 
        yellow,
        green
        /* rgba(0, 0, 0, 0) */
        ) 1 100%;
        padding: 2vh;
        text-indent: 1em;
        line-height: 25px;
    }

`;