# Timecolor

A relaxing clock with stunting colors. Features includes MVC patterns
and GET parameters.


## Build and run

Create container

    git clone ifi-timecolor
    cd ifi-timecolor
    docker run -it -v $PWD:/app -p 80:5004 microsoft/aspnet:1.0.0-rc1-final bash

Then inside

    cd /app
    dnu restore
    dnx -p project.json web

Then open your browser to ``localhost`` and relax.
