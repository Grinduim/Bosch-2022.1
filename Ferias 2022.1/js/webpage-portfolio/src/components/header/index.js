import React from "react"
import {Nav} from './styled'

export default function Header(){
    return(
        <Nav>
            <div class='item-container'>
            {/*  aqui vai ter funções para entender aonde estou */}
            <p>About</p>
            <p>Skills</p>
            <p>Works</p>
            </div>
            <div class='item-container'>
            <p>Contact</p>
            </div>
        </Nav>
    )
}