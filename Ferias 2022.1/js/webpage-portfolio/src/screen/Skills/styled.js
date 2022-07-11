import styled from "styled-components";

export const SkillsStyle = styled.div`
display: flex;
justify-content: center;
flex-direction: column;
height: 80vh;

    .main{
        margin-top: 1%;
        color:white;
        display: flex;
        margin-left: 20%;
        margin-right: 20%;
        gap: 2%;
        justify-content: space-around;

    }
        
    .container-gallery{
        display: flex;
        width: 100%;
        flex-wrap: wrap;
        gap:1%;
        height: 20%;

        /* display: grid;
        grid-template-columns: repeat(4, 1fr);
        grid-template-rows: repeat(3, 1fr);
        grid-column-gap: 20px;
        grid-row-gap: 20px; */
    }

    .container-gallery img{
        padding:10px;
        background-color:#596869;
        border-radius: 44% 88% 40% 100% / 22% 47% 48% 34%  ;
        transition:0.5s;
    }

    .container-gallery img:hover{
        transition:0.5s;
        background-color:#36453B;
    }


    img{
        width: 5em;
        height: 5em;
    }

    #text-skills{
        width: 100%;
        font-size: 25px;
        border-style: solid;
        border-width: 2px;
        padding:  2vh;
        border-image: linear-gradient(to right, darkred, darkorchid) 1;
        height: 28%;
    }

    .invisible{
        display: none;
    }


`;