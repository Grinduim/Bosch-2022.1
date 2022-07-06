import GlobalStyles from "./style/GlobalStyles";
import Header from "./components/Header/header";
import Routes from "./routes/Route";
import { BrowserRouter } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import { Provider } from "react-redux";
import store from "./store";

function App() {
  return (
    <Provider store ={store}>
    <BrowserRouter>
      <Header />
      <Routes />
      <GlobalStyles />
      <ToastContainer
        autoClose={3000} //Define quanto tempo o alerta vai ficar na tela
      />
    </BrowserRouter>
    </Provider>
  );
}

export default App;
