import React from "react";
import { CoverStyle } from "./styled";

export default function Cover() {
    return (
        <CoverStyle>
            <div class="title-container">
                <h1>Portfolio Front-End</h1>
                <p>By: Vinicius "Grinduim" Gribel</p>
            </div>
            <div class="image-container">
                <img src="images/Eu.jpg" alt="" />
                <p> ✌ Vinicius Gribel </p>
            </div>

        </CoverStyle>
    )

}