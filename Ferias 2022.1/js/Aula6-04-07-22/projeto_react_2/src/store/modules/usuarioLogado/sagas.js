import { call, put, all, takeLatest } from 'redux-saga/effects';
import * as actions from './actions';
import * as types from '../types';
const requisicao = () =>
    new Promise((resolve, reject) => { // Como não estamos conectados anenhum backend vamos simular uma requisição

        setTimeout(() => {
            resolve();
        }, 2000);
    });

function* loginRequest() {
    try {
        yield call(requisicao);
        yield put(actions.login());
    } catch {
        yield put(actions.failure());
    }
}

function* logoutRequest() {
    try {
        yield call(requisicao);
        yield put(actions.logout());
    } catch {
        yield put(actions.failure());
    }
}

export default all([
    takeLatest(types.LOGIN_REQUEST, loginRequest), // O usuário podeclicar varias vezes no botão, mas só a ultima que será realizada por causado takeLatest

    takeLatest(types.LOGOUT_REQUEST, logoutRequest),
]);