import React from "react"
import {Nav} from './styled'

export default function Header(){
    return(
        <Nav>
            <div class='item-container'>
            {/*  aqui vai ter funções para entender aonde estou */}
            <a href="#about">About</a>
            <a href="#skills">Skills</a>
            </div>
            <div class='item-container'>
            <a href="#contact">Contact</a>
            </div>
        </Nav>
    )
}