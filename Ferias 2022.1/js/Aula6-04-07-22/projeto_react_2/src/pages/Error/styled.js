import styled from "styled-components";

export const Error = styled.div`
  .error-page {
    display: flex;
    height: 25vh;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    gap: 0.5em;
    margin-top: 1em;
  }

  .error-page h1 {
    font-size: 3em;
    font-weight: 700;
  }

  .error-page p {
    font-size: 2em;
  }
`;
