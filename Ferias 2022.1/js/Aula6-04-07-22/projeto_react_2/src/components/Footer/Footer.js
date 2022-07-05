import React from "react";
import { Footer } from "./styled";
import { FaWhatsapp } from "react-icons/fa";
import GlobalStyles from "../../style/GlobalStyles";
export default function Rodape() {
  return (
      <Footer>
        <div class="container-footer">
          <div>
            <p>Todos Direitos Reservados aos McDonalds ©®</p>
          </div>
          <div class="">
            <a href="/">
              <p>Faça seu Pedido</p><FaWhatsapp size={24} />
            </a>
          </div>
        </div>
      </Footer>
      
  );
}
