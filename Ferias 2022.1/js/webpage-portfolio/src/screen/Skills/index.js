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
                        <p class="invisible" >Python ?? uma linguagem de programa????o de alto n??vel, interpretada de script, imperativa, orientada a objetos, funcional, de tipagem din??mica e forte. Foi lan??ada por Guido van Rossum em 1991.</p>
                        <p class="invisible">C# ?? uma linguagem de programa????o, multiparadigma, de tipagem forte, desenvolvida pela Microsoft como parte da plataforma .NET. A sua sintaxe orientada a objetos foi baseada no C++ mas inclui muitas influ??ncias de outras linguagens de programa????o, como Object Pascal e, principalmente, Java.</p>
                        <p class="invisible">C ?? uma linguagem de programa????o compilada de prop??sito geral, estruturada, imperativa, procedural, padronizada pela Organiza????o Internacional para Padroniza????o, criada em 1972 por Dennis Ritchie na empresa AT&T Bell Labs para desenvolvimento do sistema operacional Unix.</p>
                        <p class="invisible">JavaScript ?? uma linguagem de programa????o interpretada estruturada, de script em alto n??vel com tipagem din??mica fraca e multiparadigma. Juntamente com HTML e CSS, o JavaScript ?? uma das tr??s principais tecnologias da World Wide Web.</p>
                        <p class="invisible">HTML ?? uma linguagem de marca????o utilizada na constru????o de p??ginas na Web. Documentos HTML podem ser interpretados por navegadores. A tecnologia ?? fruto da jun????o entre os padr??es HyTime e SGML. HyTime ?? um padr??o para a representa????o estruturada de hiperm??dia e conte??do baseado em tempo</p>
                        <p class="invisible">Cascading Style Sheets ?? um mecanismo para adicionar estilo a um documento web. O c??digo CSS pode ser aplicado diretamente nas tags ou ficar contido dentro das tags do tipo style. Tamb??m ?? poss??vel, em vez de colocar a formata????o dentro do documento, criar um link para um arquivo CSS que cont??m os estilos.</p>
                        <p class="invisible">Angular ?? uma plataforma de aplica????es web de c??digo-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indiv??duos e corpora????es. Angular ?? uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.</p>
                        <p class="invisible">Git ?? um sistema de controle de vers??es distribu??do, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o hist??rico de edi????es de qualquer tipo de arquivo.</p>
                        <p class="invisible">Arduino ?? uma plataforma de prototipagem eletr??nica de hardware livre e de placa ??nica, projetada com um microcontrolador Atmel AVR com suporte de entrada/sa??da embutido, uma linguagem de programa????o padr??o, a qual tem origem em Wiring, e ?? essencialmente C/C++</p>
                        <p class="invisible">O Microsoft SQL Server ?? um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou at?? 1994, com o lan??amento da vers??o para Windows NT e desde ent??o a Microsoft mant??m a manuten????o do produto.</p>
                        <p class="invisible">O Visual Studio Code ?? um editor de c??digo-fonte desenvolvido pela Microsoft para Windows, Linux e macOS. Ele inclui suporte para depura????o, controle de versionamento Git incorporado, realce de sintaxe, complementa????o inteligente de c??digo, snippets e refatora????o de c??digo.</p>
                        <p class="invisible">Microsoft Visual Studio ?? um ambiente de desenvolvimento integrado da Microsoft para desenvolvimento de software especialmente dedicado ao .NET Framework e ??s linguagens Visual Basic, C, C++, C# e F#.</p>
                        <p>/*Click em uma imagem para aparecer o texto*/</p>
                    </div>

                </div>

            </SkillsStyle>
        </>
    )
}