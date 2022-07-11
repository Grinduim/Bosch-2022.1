import styled from "styled-components";

export const ContactStyle = styled.div`
    margin: 0 auto;
    margin-top: 100px;
    width: 100%;
    /* height:; */
    display:flex;
    flex-direction:column;
    margin-bottom: 10vh;
    align-items:center;
    margin-top:8vh;

    .contact{
        margin-top:50px;
        display: flex;
        flex-direction: column;
        text-align: center;
        justify-content: center;
        margin-left:auto;
        margin-right:auto;
        gap:10px;
    }

    .contact li{
        display:flex;
        justify-content: left;
        align-context: center;
        texxt-align: center;
    }


    .form{
        margin-top:50px;
        width: 55%;
        background-color: #f5f5f5;
        padding:3vh;
        border-radius: 10px;
        display: flex;
        justify-content: center;
        flex-direction: column;
        gap:10px;
    }

    .form h2{
        background-color: #f5f5f5;
        color: #000;
        font-size: 3vh;
        text-align: center;
    }

    .form button{
        padding: 1vh;
        text-align: center;
        margin-left: auto ;
        margin-right: auto ;
    }

    .form button:hover{
        background-color: aqua;
    }
    
    .input-field{
        width: 100%;
        background-color: #f5f5f5;
    }

    .input-field p{
        color:black;
        background-color: #f5f5f5;
    }

    .input-field input,textarea{
        color:black;
        background-color: #f5f5f5;
        padding:5px;
        border-radius:10px;
        width: calc(100% - 13px);
        border: 2px solid #ccc;
    }


`;