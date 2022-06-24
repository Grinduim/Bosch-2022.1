document.addEventListener("click", (e) => {
  const el = e.target;
  const tag = el.tagName.toLowerCase();

  if (tag === "a") {
    e.preventDefault();
    carregaPagina(el);
  }
});

async function carregaPagina(el) {
  const href = el.getAttribute("href"); // atribui o valor declarado no atributo href a uma variável
  const response = await fetch(href); // Aguarda a execução do evento, no caso o clicar do link, o fetchcria automaticamente uma promise

  const html = await response.text(); // armazena a resposta da requisição em forma de texto (código html)
  carregaResultado(html); // Chama a função que exibe o resultado
}
function carregaResultado(response) {
  const resultado = document.querySelector(".resultado"); // seleciona a div resultado.
  resultado.innerHTML = response; // muda o conteúdo html da div para a resposta da requisição.
}
