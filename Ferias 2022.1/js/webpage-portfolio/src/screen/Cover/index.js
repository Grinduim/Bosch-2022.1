import React from "react";
import { CoverStyle } from "./styled";

export default function Cover() {

    return (
        <CoverStyle>
            <div class="title-container">
                <h1 class="hello">Hello Dear! <br/>This is My Web Site Portfolio</h1>
                {/* <h1 class="text">This is My Web Site Portfolio</h1> */}
                <p>Powered: Vinicius "Grinduim" Gribel</p>
            </div>
            <div class="image-container">
                <img src="images/Eu.jpg" alt="" />
                <p> ✌ Vinicius Gribel </p>
            </div>
            <script src="https://cdn.jsdelivr.net/npm/typed.js@2.0.12"></script>
        </CoverStyle>
    )

}