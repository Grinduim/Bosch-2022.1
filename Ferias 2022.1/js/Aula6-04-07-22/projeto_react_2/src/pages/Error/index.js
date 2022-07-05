import React from "react";
import { Container } from "../../style/GlobalStyles";
import { Error } from "./styled";

export default function Page404() {
  return (
    <Container>
      <Error>
        <div class="error-page">
          <h1>Error 404!</h1>
          <h5>Pagina Não Encontrada! Volte ao menu!</h5>
        </div>
      </Error>
    </Container>
  );
}
