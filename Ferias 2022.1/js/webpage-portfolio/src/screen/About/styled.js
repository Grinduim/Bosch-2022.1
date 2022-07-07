import styled from "styled-components";

export const AboutStyle = styled.main`
    color:white;
    width: 100vw;
    height: 92vh;
    no-repeat;
    background-size: cover;
    display: grid;
    align-items: center;
    justify-content: center;
    background-image:url("https://ps-attachments.s3.amazonaws.com/cc810a17-c903-405a-b914-be7622637dc2/ixTAUT5DNBKQzZaBAixIkA.jpg");

    .glasseffect{
        width: 100vw;
        height: 92vh;
        box-shadow: 0 0 1rem 0 rgba(0, 0, 0, .2); 
        border-radius: 5px;
        background-color: rgba(255, 255, 255, .15);
        backdrop-filter: blur(10px)
    }

    .title-container{
        height: 100%;
        top:auto;
        bottom:auto;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        font-family: 'Roboto', sans-serif;
    }

    .title-container h1{
        font-size: 3em;
        text-align: center;
        letter-spacing: 8px;
        text-shadow: 5px 3px #000000;
    }

    .title-container p{
        font-size: 1.3em;
    }
    `;