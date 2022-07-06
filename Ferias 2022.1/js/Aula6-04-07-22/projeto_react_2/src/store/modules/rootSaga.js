import { all } from 'redux-saga/effects';

import usuarioLogadoSaga from './usuarioLogado/sagas';
export default function* rootSaga() {
    return yield all([
        usuarioLogadoSaga,
    ]);
}