# Comandos iniciais:
<pre>
  mkdir entity-framework
  cd entity-framework
  dotnet new mvc
</pre>

# Comandos git:
<pre>
  git init
  git add .
  git commit -m "Iniciando projeto"
  code .gitignore # gerei o conteúdo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore
  Logo Criei o repositório e rodei  os comandos
  git remote add origin https://github.com/wotoss/entity-framework.git
  git branch -M main
  git push -u origin main
</pre>

# Componentes instalados:
<pre>
  dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.8
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.8
</pre>