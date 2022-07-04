import React, { Component } from 'react'; // Importando componente
import './main.css';
import Form from './form';
import Tarefas from './tarefas'
import { FaEdit, FaWindowClose } from 'react-icons/fa'; // Biblioteca de icones disponiveis para usar no projeto "npm i react-icons"

class Main extends Component {
    state = { // Criando o state
        novaTarefa: '',
        tarefas: [],
        index: -1, // Adicionamos um index, para poder verificar se estamos modificando ou criando um elemento
    };

    handleChange = (e) => { // Função que recebe o que esta sendo escrito
        this.setState({ // Setando o state
            novaTarefa: e.target.value,
        });
    };

    handleDelete = (e, index) => {
        const { tarefas } = this.state;
        const novasTarefas = [...tarefas];
        novasTarefas.splice(index, 1);

        this.setState({
            tarefas: [...novasTarefas],
        })
    }

    handleSubmit = (e) => {
        e.preventDefault();
        const { tarefas, index } = this.state;
        let { novaTarefa } = this.state;
        novaTarefa = novaTarefa.trim();

        if (tarefas.indexOf(novaTarefa) !== -1) return;

        if (index === -1) {
            this.setState({
                tarefas: [...tarefas, novaTarefa],
                novaTarefa: ''
            });
        } else {
            tarefas[index] = novaTarefa;

            this.setState({
                tarefas: [...tarefas],
                index: -1,
                novaTarefa: ''
            })
        };
    };



    handleEdit = (e, index) => {
        const { tarefas } = this.state;
        this.setState({
            index, // colocamos o index como o index que pegamos do item
            novaTarefa: tarefas[index],
        });
    };

    componentDidUpdate(prevProps, prevState) {
        const { tarefas } = this.state;

        if (tarefas === prevState.tarefas) return;

        localStorage.setItem('tarefas', JSON.stringify(tarefas));
    };


    componentDidMount() {
        const tarefas = JSON.parse(localStorage.getItem('tarefas'));
        if (!tarefas) return;
        this.setState({ tarefas });
    };

    render() {
        const { novaTarefa } = this.state; // Criando a constante
        let { tarefas } = this.state;

        return (
            <div className='main'>
                <h1>Lista de tarefas</h1>
                <p>Tarefa sendo digitada: {novaTarefa}</p>
                <Form
                handleSubmit = {this.handleSubmit}
                handleDelete = {this.handleDelete}
                handleChange = {this.handleChange}
                novaTarefa = {this.novaTarefa}
                />
            <Tarefas
            
            handleEdit= {this.handleEdit}
            handleDelete  = {this.handleDelete}
            tarefas = {tarefas}
            />
            </div>
        );
    };
};

export default Main;

