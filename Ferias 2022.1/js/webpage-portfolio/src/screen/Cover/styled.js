import styled from "styled-components";
import { Colors } from "../../config/colors";
import { TitleFont } from "../../config/font";

export const CoverStyle = styled.main`
    color:white;
    width: 100%;
    height: 100vh;
    margin-top: 4vh;
    display: flex;
    align-items: center;
    flex-wrap: wrap;
    justify-content:space-around;
    background-color:black;

    .title-container{
        
        top:auto;
        bottom:auto;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        font-family: 'Roboto', sans-serif;
    }

    .title-container h1{
        font-size: 2.5em;
        text-align: center;
        letter-spacing: 8px;
        text-shadow: 5px 3px #414535;
        font-family: ${TitleFont};
    }
    .title-container p{
        font-size: 1.3em;
    }

    .image-container{
        display: flex;
        justify-content: center;
        flex-direction: column;
        align-items: center;
        gap: 20px;
    }
    img{
        width: 300px;
        height: 300px;
        border-radius: 200px;
        object-fit: cover;
        object-position: 100% 80%;
        border: 3px solid white

    }

    p{
        text-align: center;
        font-size: 1.8em;
        font-family: ${TitleFont};
    }
    `;