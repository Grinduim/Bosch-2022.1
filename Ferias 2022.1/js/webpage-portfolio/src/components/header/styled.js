import styled from "styled-components";


export const Nav = styled.nav`
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    z-index: 99999;
    background: black;
    height:8vh;
    display: flex;
    align-items: center;
    justify-content: right;
    text-align: center;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    color:white;

    .item-container{
        display: flex;
        flex-direction: row;
        gap:10px;
        margin-right: 1.5em;
        margin-left: 1.5em;
    }

    .item-container a{
        text-decoration: none;
        font-size: 1.3em;
    }


 `;