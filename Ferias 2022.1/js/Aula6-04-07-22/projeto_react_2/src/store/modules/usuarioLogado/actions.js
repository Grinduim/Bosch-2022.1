import * as types from '../types'

export function login() {
    return {
        type: types.BOTAO_LOGIN
    };
}
export function logout() {
    return {
        type: types.BOTAO_LOGOUT
    };
}

export function login_request() {
    return {
        type: types.LOGIN_REQUEST
    };
}

export function logout_request() {
    return {
        type: types.LOGOUT_REQUEST
    };
}

export function failure() {
    return {
        type: types.BOTAO_FAILURE
    };
}