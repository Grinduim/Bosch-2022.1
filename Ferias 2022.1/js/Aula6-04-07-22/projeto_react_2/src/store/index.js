import { createStore } from "redux";

const initialState = {
  logado: false,
}; // Todos os estados iniciais
const reducer = (state = initialState, action) => {
  const newState = { ...state }; // Criamos o novo estado
  switch (action.type) {
    case "LOGIN":
      newState.logado = true; // Caso a ação seja de login deixamos o estado como verdadeiro

      return newState;

    case "LOGOUT":
      newState.logado = false; // Caso a ação seja de logout deixamos o estado como falso

      return newState;

    default:
      return state;
  }
};

const store = createStore(reducer);

export default store;
