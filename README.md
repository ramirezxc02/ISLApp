# ISLApp 
***
Es una aplicación de escritorio para automatizar el registro de las actividades ilícitas cometidas por diferentes actores que visitan la isla. Además, este sistema genera reportes a partir de los registros creados. 

## Tabla de contenido
1. [Info-General](#info-general)
2. [Tecnologías](#tecnologías)
3. [Instalación](#instalación)
4. [Colaboración](#colaboración)
5. [FAQs](#faqs)

## Info-General
***
Esta aplicación se compone de tres módulos principalmente.
1. Módulo de Usuarios: en este se realiza un CRUD para la manipulación y control de los usuarios que utilizan el sistema.
2. Módulo de Reportes: genera un documento con los datos ingresados por el usuario.
3. Módulo Infractor: se agregan los datos básicos del autor de la actividad ilícita.

Como funcionalidades extra se ocupa validar que la cédula que el autor provee sea información certera, para ello se ocupa integrar una API para consultar al registro civil. También se ocupa poder personalizar el tema entre claro u oscuro para una mayor experiencia de usuario. Finalmente, el usuario puede exportar sus reportes a archivos pdf para uso externo.

## Tecnologías
***

* .Net Framework(WinForm)
* C#
* Visual Studio Community

## Instalación
***
A little intro about the installation. 
```
$ git clone https://example.com
$ cd ../path/to/the/file
$ npm install
$ npm start
```
Side information: To use the application in a special environment use 

## Colaboración
***
Give instructions on how to collaborate with your project.
> Maybe you want to write a quote in this part. 
> It should go over several rows?
> This is how you do it.

## FAQs
***
A list of frequently asked questions
1. **This is a question in bold**
Answer of the first question with _italic words_. 
2. __Second question in bold__ 
To answer this question we use an unordered list:
* First point
* Second Point
* Third point
3. **Third question in bold**
Answer of the third question with *italic words*.
4. **Fourth question in bold**
| Headline 1 in the tablehead | Headline 2 in the tablehead | Headline 3 in the tablehead |
|:--------------|:-------------:|--------------:|
| text-align left | text-align center | text-align right |


#Referencia para actualizar este archivo: https://www.ionos.es/digitalguide/paginas-web/desarrollo-web/archivo-readme/
