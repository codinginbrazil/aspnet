#!/bin/bash
#Init: Git Ignore


touch .gitignore

echo "# Init: Git Ignore
# Este gitignore foi gerado automaticamente.
# Note que para realizar alteração das tecnologias é necessário alterar os arquivos shell na pasta gitignore 

.idea" > .gitignore

sh ./.init/gitignore/vscode.sh
