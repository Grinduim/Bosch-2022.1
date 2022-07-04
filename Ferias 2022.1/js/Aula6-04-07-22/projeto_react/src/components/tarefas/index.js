import { Component } from "react";
import React from 'react';
import { FaEdit,FaWindowClose } from 'react-icons/fa';
import PropTypes from 'prop-types';
import './tarefa.css';

function Tarefas(handleEdit, handleDelete, tarefas) {
    return (
        <ul className='tarefas' >
            {
                tarefas.map((tarefa, index) => (
                    <li key={tarefa}>
                        {tarefa}
                        <span>
                            <FaEdit className='edit' onClick={(e) =>
                                handleEdit(e, index)} />

                            <FaWindowClose className='delete' onClick={(e) =>
                                handleDelete(e, index)} />

                        </span>
                    </li>
                ))
            }
        </ul>
    );
};

export default Tarefas;