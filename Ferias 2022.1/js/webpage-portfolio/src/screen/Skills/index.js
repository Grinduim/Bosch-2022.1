import React from "react";
import { SkillsStyle } from "./styled";
import { Title } from "../../config/title";

export default function Skills() {


    function Teste(indexmsg) {
        let div = document.querySelector("#text-skills")
        let ps = div.querySelectorAll("p");

        for (let index = 0; index < ps.length; index++) {
            const element = ps[index];
            console.log(element);
            element.classList.add("invisible");
        }

        ps[indexmsg - 1].classList.remove("invisible")
    }
    return (
        
        <>
            
            <SkillsStyle id = "skills">
            <Title >Skills</Title>
                <div class="main">
                    <ul class="container-gallery">
                        <li onClick={() => Teste(1)}><img src="http://assets.stickpng.com/images/5848152fcef1014c0b5e4967.png" alt="" /></li>
                        <li onClick={() => Teste(2)}><img src="https://raw.githubusercontent.com/learnbr/csharp/master/csharp-logo.png" alt="" /></li>
                        <li onClick={() => Teste(3)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/c/c-original.svg" alt="" /></li>
                        <li onClick={() => Teste(4)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/javascript/javascript-original.svg" alt="" /></li>
                        <li onClick={() => Teste(5)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/html5/html5-original-wordmark.svg" alt="" /></li>
                        <li onClick={() => Teste(6)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/css3/css3-original-wordmark.svg" alt="" /></li>
                        <li onClick={() => Teste(7)}><img src="https://cdn.icon-icons.com/icons2/2107/PNG/512/file_type_angular_icon_130754.png" alt="" /></li>
                        <li onClick={() => Teste(8)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/git/git-original.svg" alt="" /></li>
                        <li onClick={() => Teste(9)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/arduino/arduino-original.svg" alt="" /></li>
                        <li onClick={() => Teste(10)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/microsoftsqlserver/microsoftsqlserver-plain-wordmark.svg" alt="" /></li>
                        <li onClick={() => Teste(11)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/vscode/vscode-original.svg" alt="" /></li>
                        <li onClick={() => Teste(12)}><img src="https://raw.githubusercontent.com/devicons/devicon/1119b9f84c0290e0f0b38982099a2bd027a48bf1/icons/visualstudio/visualstudio-plain.svg" alt="" /></li>
                    </ul>
                    <div id="text-skills">
                        <p class="invisible" >Python é uma linguagem de programação de alto nível, interpretada de script, imperativa, orientada a objetos, funcional, de tipagem dinâmica e forte. Foi lançada por Guido van Rossum em 1991.</p>
                        <p class="invisible">C# é uma linguagem de programação, multiparadigma, de tipagem forte, desenvolvida pela Microsoft como parte da plataforma .NET. A sua sintaxe orientada a objetos foi baseada no C++ mas inclui muitas influências de outras linguagens de programação, como Object Pascal e, principalmente, Java.</p>
                        <p class="invisible">C é uma linguagem de programação compilada de propósito geral, estruturada, imperativa, procedural, padronizada pela Organização Internacional para Padronização, criada em 1972 por Dennis Ritchie na empresa AT&T Bell Labs para desenvolvimento do sistema operacional Unix.</p>
                        <p class="invisible">JavaScript é uma linguagem de programação interpretada estruturada, de script em alto nível com tipagem dinâmica fraca e multiparadigma. Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.</p>
                        <p class="invisible">HTML é uma linguagem de marcação utilizada na construção de páginas na Web. Documentos HTML podem ser interpretados por navegadores. A tecnologia é fruto da junção entre os padrões HyTime e SGML. HyTime é um padrão para a representação estruturada de hipermídia e conteúdo baseado em tempo</p>
                        <p class="invisible">Cascading Style Sheets é um mecanismo para adicionar estilo a um documento web. O código CSS pode ser aplicado diretamente nas tags ou ficar contido dentro das tags do tipo style. Também é possível, em vez de colocar a formatação dentro do documento, criar um link para um arquivo CSS que contém os estilos.</p>
                        <p class="invisible">Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.</p>
                        <p class="invisible">Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.</p>
                        <p class="invisible">Arduino é uma plataforma de prototipagem eletrônica de hardware livre e de placa única, projetada com um microcontrolador Atmel AVR com suporte de entrada/saída embutido, uma linguagem de programação padrão, a qual tem origem em Wiring, e é essencialmente C/C++</p>
                        <p class="invisible">O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.</p>
                        <p class="invisible">O Visual Studio Code é um editor de código-fonte desenvolvido pela Microsoft para Windows, Linux e macOS. Ele inclui suporte para depuração, controle de versionamento Git incorporado, realce de sintaxe, complementação inteligente de código, snippets e refatoração de código.</p>
                        <p class="invisible">Microsoft Visual Studio é um ambiente de desenvolvimento integrado da Microsoft para desenvolvimento de software especialmente dedicado ao .NET Framework e às linguagens Visual Basic, C, C++, C# e F#.</p>
                        <p>/*Click em uma imagem para aparecer o texto*/</p>
                    </div>

                </div>

            </SkillsStyle>
        </>
    )
}