import React from 'react';
import { FaHome, FaUserAlt, FaSignOutAlt } from 'react-icons/fa';
import { Nav } from './styled';
export default function Header() {
    return (
        <Nav>
            <a href='/'>
                <FaHome size={24} />
            </a>
            <a href='login'>
                <FaUserAlt size={24} />
            </a>
            <a href='logout'>
                <FaSignOutAlt size={24} />
            </a>
        </Nav>
    );
}