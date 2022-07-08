import styled from "styled-components";
// import { Colors } from "../../config/colors";
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
        justify-content: left;
        align-items: left;
        font-family: 'Roboto', sans-serif;
    }

    .title-container h1{
        font-size: 2.5em;
        text-align: left;
        letter-spacing: 8px;
        text-shadow: 5px 3px #414535;
        font-family: ${TitleFont};

        overflow: hidden; /* Ensures the content is not revealed until the animation */
        border-right: .15em solid orange; /* The typwriter cursor */
        white-space: nowrap; /* Keeps the content on a single line */
        margin: 0 auto; /* Gives that scrolling effect as the typing happens */
        letter-spacing: .15em; /* Adjust as needed */
        animation: 
            typing 3.5s steps(40, end),
            blink-caret .75s step-end infinite;
    }

    @keyframes typing {
        from { width: 0 }
        to { width: 100% }
      }

      @keyframes blink-caret {
        from, to { border-color: transparent }
        50% { border-color: red; }
      }
    .title-container p{
        margin-top: 0.8em;
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
        border: 3px solid white;
        transition: 0.8s;
    }

    img:hover{
        border: 3px solid red;
        border-radius:100px;
        width: 500px;
        height: 500px;
        transition: 0.8s;
    }


    p{
        text-align: center;
        font-size: 1.8em;
        font-family: ${TitleFont};
    }
    `;