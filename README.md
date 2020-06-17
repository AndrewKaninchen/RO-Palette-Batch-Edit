# RO-Palette-Batch-Edit

Pequeno programa feito para gerar variações de color palettes para o jogo Ragnarok Online, atualmente com o intuito específico de criar variações para diversos tons de pele.

## Instruções

Para que o programa funcione, é necessário que todos os palettes que serão usados como base para as variações estejam em uma mesma pasta, já extraídos do .rgf do jogo.

O programa deve ser movido para o mesmo diretório raiz desta pasta, estando ao lado dela:

![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_5.png)

![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_6.png?raw=true)

Uma vez feito isto, o programa pode ser rodado. Ele pedirá que o usuário digite o nome desta pasta de base.

![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_7.png?raw=true)

Tendo digitado o nome da pasta de base, a próxima coisa pedida será o nome da pasta que será criada para a primeira derivação de sprites. Na forma atual do programa, cada tom de pele receberá sua própria pasta, contendo as variações de cada color palette, todas com o mesmo nome. Caso isto seja um problema, o programa pode facilmente ser alterado para fazer isto na forma de um sufixo ou prefixo no nome de cada arquivo, ao invés de usar diretórios. No momento, entretanto, ele não tem este comportamento.

![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_8.png?raw=true)

Tendo digitado o nome da pasta da primeira derivação, o programa pedirá que o usuário digite as cores que entrarão para aquele tom de pele. 
O formato desejado é **exatamente o que vem em uma cópia (usando Ctrl+C) de um gradiente selecionado no programa Act Editor**. Basta selecionar o gradiente correto, que é o indicado na imagem, e apertar Ctrl+C para copiar ele para o clipboard, e Ctrl+V para colá-lo no programa (ou usar um .txt intermediário para criar todas as variações antes, para ficar mais fácil)
![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_12.png?raw=true)

![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_9.png)

Feito isto, o programa gerará todas as variações de palettes do diretório base no novo, lhe dando a opção de gerar uma nova pasta, com mais variações, repetindo o processo.

![alt text](https://github.com/AndrewKaninchen/RO-Palette-Batch-Edit/blob/master/Screenshot_11.png?raw=true)

Quando o usuário terminar de colocar todas as variações de gradientes desejadas, basta fechar o programa, apertando Enter sem digitar o nome de uma nova pasta ou apertando o botão de fechar da janela.
