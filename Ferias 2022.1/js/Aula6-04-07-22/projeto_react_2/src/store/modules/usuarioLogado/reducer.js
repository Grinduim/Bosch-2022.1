import * as types from '../types';

const initialState = {
    logado: false,
};
// eslint-disable-next-line
export default function (state = initialState, action) {
    const newState = { ...state };

    switch (action.type) {
        case types.BOTAO_LOGIN:
            console.log("Login realizado");
            newState.logado = true;
            return newState;

        case types.BOTAO_LOGOUT:
            console.log("Logout realizado");
            newState.logado = false;
            return newState;

        case types.LOGIN_REQUEST:
            console.log("Fazendo requisição");
            return state;

        case types.LOGOUT_REQUEST:
            console.log("Fazendo requisição");
            return state;

        case types.BOTAO_FAILURE:
            console.log("Requisição negada");
            return state;

        default:
            return state;
    };
};