# Technical-Artist-Test
Geta Game Studio / Technical Artist Test
PRUEBA DE TECHNICAL ARTIST PARA GETA GAME STUDIO

Desarrollé una escena en unity de un campamento al aire libre con ambiente de noche, los assets fueron descargados de fuentes gratuitas.
La intención de este proyecto era demostrar mis habilidades en integración, composición, optimización y manejo de VFX en shaders y particulas
así como un buen uso de Unity y repositorios en general. 

En un principio los assets que descargué tenian todas las texturas sueltas, lo que implicaba tener muchos materiales y texturas distintas en escena (draw calls) 
por lo que fusioné estas texturas en solo un par de mapas (atlas de texturas) y rápidamente escale los UVS de los modelos para que estos coincidieran, además
de designar texturas más chicas para modelos que no iban a tener mucha importancia en la escena. 

Seguido de esto, limpié los modelos de los materiales que se importan por defecto al proyecto, y me asegure de tener texturas de no más de 2048 px, aunque la mayoría de 
los atlas son de 1024, esto es porque siempre es más fácil quitar que agregar resolución en caso de ser necesario. 

Una vez listo esto integré la escena, hice un escenario pequeño debido al tiempo, pensé en algo chico pero bien construido. Agregué luces y la iluminación correspondiente.
Elaboré un shader de distorsión de textura para el pasto alto y que éste tuviera un efecto de viento, mismo que es muy ligero ya que son solo billboards y lo que se distorsiona
es la textura.

Así mismo añadí una fogata con una particula de fuego en spritesheet, esto porque para lograr animaciones en particulas siempre es más barato tener un sprite sheet con la 
animación de la particula completa previamente bakeada (en la mayoría de los casos). y algunas particulas decorativas como luciernagas, rayos de luz de luna y brasas de fuego.

Elaboré también el shader de suelo que se pidio en la prueba con la opción de modificar el Roughness, este material se llama "GroundShader" y está en la carpeta de "ShaderGraph",
NOTA: Si intentan modificar algún atributo de este material en la escena no funcionará, ya que todo tiene bake de luces, se puede agregar a un plano el material para probar.

Seguido de esto, procedí al bake de iluminación, hice bake de luces, sombras, iluminación global y ambient occlusion, despues de esto apagué las luces en escena para
comprobar su efectividad, no hay luces ni sombras en tiempo real en la presente escena, se pueden comprobar las luces apagadas.
Esto con la finalidad de optimizar recursos y que va de la mano con los atlas de texturas, las particulas de igual manera estan entrando en el dynamic batching por lo que
su peso en escena es muy poco. 

Finalmente agregué los post procesos, estos lo hago siempre al final ya que primero me aseguro de que la escena se vea suficientemente bien sin ellos en caso de que 
las limitaciones técnicas no nos permitan usarlos. 
Usé Bloom , Vintage, corrección de color y desenfoque para levantar la escena, esto solo tendrá un buen funcionamiento en PC, para una versión de teléfono se deben 
apagar estos post procesos y desactivar el Anti-aliasing de la cámara. 

Se agregó sonido ambiental de bosque en 3D.

Por las limitaciones de tiempo solo pude agregar un script de waypoints muy sencillo, en donde la cámara mira de inicio 1 waypoint (que son objetos en la escena) y avanza 
hacia ellos, una vez choca con el primero se dirige al segundo, luego al tercero y así sucesivamente, esto comienza a funcionar presionando barra espaciadora y se pueden
modificar los waypoints a gusto o agregar más. 

Para finalizar, me gustaría aclarar que no elaboré el shader del auto porque no terminé de entender bien la instrucción, ya que no tenía un modelo especifico para coche,
o no sé si se esperaba un shader procedural que cambiara de pintura solo para ponerse sobre la carcasa de cualquier vehículo, en cualquier caso si pudieran aclararme esta duda
y hay oportunidad sobre el tiempo con gusto subo un nuevo material.

Espero que encuentren agradable la prueba y quedo pendiente de su respuesta, les agradezco de antemano.

Josué Ortigoza Ramos.



REFERENCIAS DE ASSETS:

https://assetstore.unity.com/packages/3d/environments/fantasy/a-piece-of-nature-40538
https://assetstore.unity.com/packages/3d/environments/fantasy/campfire-pack-11256
https://in.pinterest.com/pin/8866530500618748/
http://soundbible.com/1818-Rainforest-Ambience.html
