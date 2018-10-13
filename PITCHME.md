@title[Cover]

@snap[north-west byline]
  Software Development Series
@snapend

@snap[west headline text-white]
	@size[0.75em](@color[orange](T)est @color[orange](D)riven @color[orange](D)evelopment)  
  @size[0.75em](in .NET Core) C#  
@snapend

---

@title[Snap]

@snap[north]
NORTH
@snapend

@snap[north-west template-note]
north-west
@snapend

@snap[north-east template-note]
north-east
@snapend

@snap[west]
WEST
@snapend

@snap[midpoint]
MIDPOINT
@snapend

@snap[east]
EAST
@snapend

@snap[south]
SOUTH
@snapend

@snap[south-west byline text-white]
south-west
@snapend

@snap[south-east template-note]
south-east
@snapend

---?image=assets/img/logo/logo.png&opacity=50

@title[Background & Icons]

# Title

https://fontawesome.com/icons?from=io

@fa[arrow-down text-black]
@fa[calendar]
@title[Contact Me]
[@color[orange](@fa[github-square pad-right-icon]@css[git-handle](GitHub))](https://github.com/saladpuk)
[@color[orange](@fa[envelope-o pad-right-icon]@css[contact-email](au.perspectives@gmail.com))](mailto: au.perspectives@gmail.com)

+++

@title[List]

## Step-by-Step

@snap[midpoint list-content-concise span-100]
@ol
- Lorem ipsum dolor sit amet
- Consectetur adipiscing elit
- Sed do eiusmod tempor
@olend
<br><br>
@snapend

---
@title[Code]

```
// Include http module.
var http = require("http");

// Create the server. Function passed as parameter
// is called on every request made.
http.createServer(function (request, response) {
  // Attach listener on end event.  This event is
  // called when client sent, awaiting response.
  request.on("end", function () {
    // Write headers to the response.
    // HTTP 200 status, Content-Type text/plain.
    response.writeHead(200, {
      'Content-Type': 'text/plain'
    });
    // Send data and end response.
    response.end('Hello HTTP!');
  });

// Listen on the 8080 port.
}).listen(8080);
```

@[1,2](You can present code inlined within your slide markdown too.)
@[9-17](Your code is displayed using code-syntax highlighting just like your IDE.)
@[19-20](Again, all of this without ever leaving your slideshow.)

+++
@title[Tree]

```text
.
├── PITCHME.md
├── PITCHME.yaml
└── template
    ├── css
    │   └── PITCHME.css
    ├── img
    │   ├── batman.png
    │   ├── dataflow.png
    │   ├── developer.jpg
    │   └── ....
    └── md
        ├── about/PITCHME.md
        ├── announcement/PITCHME.md
        ├── code-presenting/PITCHME.md
        ├── header-footer/PITCHME.md
        ├── image/PITCHME.md
        ├── list-content/PITCHME.md
        ├── quotation/PITCHME.md
        ├── sidebar/PITCHME.md
        ├── sidebox/PITCHME.md
        ├── split-screen/PITCHME.md
        └── wrap-up/PITCHME.md
```

@[1-3, 6](Code presenting can also be used to step through any text-based content.)
@[4,5,7,12](Here for example we can navigate through the directory structure for this template.)
@[12-23](We can see that this template uses GitPitch's cool modular markdown support @fa[smile-o fa-spin])


---
@title[Quote]

@snap[north-east span-60]
@quote[We cannot solve our problems with the same thinking we used when we created them.]
@snapend

@snap[east text-blue span-50]
@quote[Houston, Tranquillity Base here. The Eagle has landed.](Neil Armstrong)
@snapend

@snap[south-east span-50]
@quote[GitPitch Desktop with speaker notes is AMAZING!](Dave T.)
@snapend

@snap[north-west]
<br>
@quote[GitPitch is just WONDERFUL!](Mohammed A.)
@snapend

@snap[south-west span-20]
@quote[Just discovered GitPitch. And WOW!](Adrian K.)
@snapend

---?image=assets/img/bg/orange.jpg&position=right&size=50% 100%
@title[Split-Screen-1]

@snap[west split-screen-heading text-orange span-50]
Topics to be covered today
@snapend

@snap[east text-white span-45]
@ol[split-screen-list](false)
- Lorem ipsum dolor sit amet, consectetur elit
- Ut enim ad minim veniam, quis exercitation
- Duis aute irure dolor in reprehenderit in voluptate
@olend
@ul[split-screen-list](false)
- Lorem ipsum dolor sit
- Lorem ipsum dolor sit
@ulend
@snapend

+++?image=assets/img/bg/black.jpg&position=left&size=50% 100%

@title[Split-Screen-Image]

@snap[west split-screen-byline text-white]
Lorem ipsum<br>sit dolor amet, consectetur elit.
@snapend

@snap[midpoint split-screen-img fragment]
![DEVELOPER](assets/img/logo/logo.png)
@snapend

@snap[east split-screen-text text-black]
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
@snapend

---

@title[End]

@snap[west headline span-100]
Thank you ;)  
@snapend

@snap[south-west byline text-white]
@fa[comments] Leave your questions below
@snapend

@snap[south-east byline text-white]
@fa[graduation-cap] See all courses [@Saladpuk.com](http://www.saladpuk.com)
@snapend