import React from "react";
import { Title } from "../../config/title";
import { ContactStyle } from "./styled";
import { FaLinkedin, FaInstagram, FaPhoneAlt, } from "react-icons/fa";
import { AiOutlineMail } from "react-icons/ai";

export default function Contact() {

    // function SubmitForm(e){
    //     e.preventDefault();
    //     // let name = document.getElementById("name");
    //     let email = document.getElementById("email");
    //     // let message = document.getElementById("message");
    //     // let subject = document.getElementById("subject");
        
    //     // name.value = "";
    //     email.value = "";
    //     // message.value = " ";
    //     // subject.value = "";
    // }

    return (
        <ContactStyle id="contact">
            <Title>Contact</Title>
            <ul class="contact" >
                <li><FaLinkedin size={24} />: Vinicius Gribel</li>
                {/*  função que vai redirecionar para cada uma das minhas paginas  */}
                <li><FaInstagram size={24} />: @gribel.py</li>
                <li><FaPhoneAlt size={24} />: +55 (41) 995885793</li>
                <li><AiOutlineMail size={24} />: viniciusgribelperson@gmail.com</li>
            </ul>
            <form  class="form">
                <h2>Send me a message</h2>
                <div class="input-field">
                    <p>Name:</p>
                    <input type="text" name="name" placeholder="Name" id="name" />
                </div>
                <div class="input-field">
                    <p>Email:</p>
                    <input type="email" name="name" placeholder="Email:" id="mail"/>
                </div>
                <div class="input-field">
                    <p>Subject:</p>
                    <input type="text" name="name" placeholder="Subject:"  id="subject"/>
                </div>
                <div class="input-field">
                    <p>Message:</p>
                    <textarea type="text" name="name" placeholder="Message:" rows="6"  id="message"/>
                </div>

                <button type="submit">Send!</button>
            </form>
        </ContactStyle>
    )
}