import styled from "styled-components";
import { Colors } from "../../config/colors";
import { TitleFont } from "../../config/font";

export const AboutStyled = styled.section`
    padding-top: 200px;
    width: 100%;
    height:60vh;
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
    .container-about{
        // display: grid;
        // grid-template-columns: 60%  40%;
        // grid-gap:3em
        display: flex;
        justify-content: center;
    }
    .text{  
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
        rgba(0, 0, 0, 0) 
        ) 1 100%;
        padding: 2vh;
        text-indent: 1em;
        line-height: 25px;
        /* grid-are */
    }          
    
    .emphasis{
        display: inline;
        color: red
    }

`;