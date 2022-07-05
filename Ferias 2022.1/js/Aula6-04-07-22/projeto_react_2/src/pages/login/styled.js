import styled from 'styled-components';

const handleColorType = color => {
    if(color){
        if(color === "primary")
            return "lightcoral"
        return color;
    }
}

export const Title = styled.h1`
    /* color: ${ props => props.isRed ? 'red' : 'blue' }; // Ao invés de  passarmos um cor direto para o titulo agora podemos mudar ela direto no index.js */
    small{
        font-size: 0.5em;
        margin-left: 15px;
        color: black;
    }
    color: ${({color}) => handleColorType(color)} 
`;