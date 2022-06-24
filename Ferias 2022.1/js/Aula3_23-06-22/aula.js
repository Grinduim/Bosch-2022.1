/////////////////////////////////////////
// PROMISES //
function rand(min, max) {
  min *= 1000;
  max *= 1000;
  return Math.floor(Math.random() * (max - min) + min);
}

function wait(msg, time) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve(-"Resolvido");
    }, time);
  });
}

const promises = [
  wait("Promise 1", 2000),
  wait("Promise 2", 500),
  wait("Promise 3", 4000),
];

Promise.race(promises)
  .then(function (valor) {
    console.log(valor);
  })
  .catch(function (erro) {
    console.log(erro);
  });
