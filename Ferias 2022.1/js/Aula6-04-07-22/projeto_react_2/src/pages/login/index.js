import React from "react";
import { Title } from "./styled";
import { Container } from "../../style/GlobalStyles";

export default function Login() {
  return (
    <>
      <Container>
        <Title color="primary">
          Login
          <small>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut
            ultricies leo et urna fringilla, tempus dictum est gravida.
          </small>
        </Title>
        <p>Pellentesque facilisis tempus lobortis.</p>
      </Container>
    </>
  );
}
