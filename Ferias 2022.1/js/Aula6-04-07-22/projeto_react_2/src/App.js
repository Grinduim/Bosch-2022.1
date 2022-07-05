import GlobalStyles from "./style/GlobalStyles";
import Header from "./components/Header/header";
import Rodape from "./components/Footer/Footer";
import Routes from "./routes/Route";
import { BrowserRouter } from "react-router-dom";
import { ToastContainer } from "react-toastify";

function App() {
  return (
    <BrowserRouter>
      <Header />
      <Routes />
      <Rodape />
      <GlobalStyles />
      <ToastContainer
        autoClose={3000} //Define quanto tempo o alerta vai ficar na tela
      />
    </BrowserRouter>
  );
}

export default App;
