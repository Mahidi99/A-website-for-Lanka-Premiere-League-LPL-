@import url(<link href="https://fonts.googleapis.com/css2?family=Cinzel:wght@500&display=swap" rel="stylesheet">);
/* ---- Layout Containers ---- */
*{
	-moz-box-sizing: border-box;
    box-sizing: border-box;
    margin: 0;
	font-family: Roboto;
	position: relative
}


html {
    scroll-behavior: smooth;
  }

body {
	font-family: 'Varela Round', sans-serif;
	line-height: 1.6;
	color: #4f1519;
}


a{
    text-decoration: none;
    color: white;
}

a:hover{
    color: gray;


}

.logo{
	/*position: absolute;*/
	height: 100px;
	width: 200px;
	margin-left: 5%;
	/*margin-top:1%;*/
}


.container{
    height: 75px;
    background-color: #121266;
    background-size: cover;
    width: 100%;
    z-index: 90;
	position: fixed;
	overflow: hidden;
  margin-right: 2%;
}

/* ---- Navigation ---- */

.logoTop{
  /*position: absolute;*/
  height: 50px;
  width: 100px;
  margin-left: 5%;
  margin-top:1%;*/
}

.main-nav{
    float: right;
    margin-left: 330px;
	max-width: 1000px;
  justify-content: center;
  align-items: center;
}



.main-nav a{
    text-align: center;
    font-size: 1.2em;
    color: white;
    opacity: 1;
    text-transform: uppercase;
    padding: 5px 5px;
    transition: 0.4s ease;
}

.main-nav a:hover {
    opacity: .5;
}

.main-nav li {
    display: inline-block;
    margin-left: 15px;
    margin-top: 25px;
    
}

/* Slideshow container */
.mySlides {display: none;}
img {vertical-align: middle;}

.slideshow-container {
  max-width: 100%;
  position: relative;
  margin: auto;
}

/* Next & previous buttons */
.prev, .next {
  cursor: pointer;
  position: absolute;
  top: 50%;
  width: auto;
  padding: 16px;
  margin-top: -22px;
  color: white;
  font-weight: bold;
  font-size: 18px;
  transition: 0.6s ease;
  border-radius: 0 3px 3px 0;
  user-select: none;
}







}
h6{
	font-size:23px;
	margin-top:15%;
	color: black;
}
.container5{
  width: 100%;
  box-sizing: border-box;
  height: 100%;
  background-color:#4f1519;
}
.button1 {
  background-color: black;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin-top:5px;
  margin-bottom:10px;
  margin-left:14%;
  cursor: pointer;
}
.button2 {
  background-color: black;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin-top:5px;
  margin-bottom:10px;
  margin-left:11.5%;
  cursor: pointer;
}





/***************************************footer stylings*********************************************************/

.footerContent{
  background: #121266;
  box-shadow: 0 1px 1px 0 rgba(0, 0, 0, 0.12);
  box-sizing: border-box;
  width: 100%;
  text-align: left;
  font: bold 16px ;
  font-family: 'Cinzel', serif;
  padding: 55px 50px;
}

.footerContent .footerLeft,
.footerContent .footerCenter,
.footerContent .footerRight{
  display: inline-block;
  vertical-align: top;
}

.footerContent .footerLeft{
  width: 42%;
  font: bold 16px ;
}

.footerContent h3{
  color:  #ffffff;
  font-size: 36px;
  font-family: 'Kaushan Script', cursive;
  font-family: 'Merienda', cursive;
  margin: 0;
}

.footerContent h3 span{
  color:  lightseagreen;
}

.footerContent .footerLinks{
  color:  #ffffff;
  margin: 20px 0 12px;
  padding: 0;
}

.footerContent .footerLinks a{
  display:inline-block;
  line-height: 1.8;
    font-weight:400;
  text-decoration: none;
  font-size: 22px;
  color:  inherit;
}

.footerContent .footerCompName{
  color:  #222;
  font-size: 14px;
  font-weight: normal;
  margin: 0;
  color: gray;
}

.footerContent .footerCenter{
  width: 35%;
}

.footerContent .footerCenter i{
  background-color:  #33383b;
  color: #ffffff;
  font-size: 25px;
  width: 38px;
  height: 38px;
  border-radius: 50%;
  text-align: center;
  line-height: 42px;
  margin: 10px 15px;
  vertical-align: middle;
}

.footerContent .footerCenter i.fa-envelope{
  font-size: 17px;
  line-height: 38px;
}

.footerContent .footerCenter p{
  display: inline-block;
  color: #ffffff;
  font-weight:400;
  vertical-align: middle;
  margin:0;
}

.footerContent .footerCenter p span{
  display:block;
  font-weight: normal;
  font-size:14px;
  line-height:2;
}

.footerContent .footerCenter p a{
  color:  lightseagreen;
  text-decoration: none;;
}

.footerContent .footerLinks a:before {
  content: "|";
  font-weight:100;
  font-size: 10px;
  left: 0;
  color: #fff;
  display: inline-block;
  padding-right: 2px;
}

.footerContent .footerLinks .link-1:before {
  content: none;
}

.footerContent .footerRight{
  width: 20%;
}

.footerContent .footerCompAbout{
  line-height: 20px;
  color:  #92999f;
  font-size: 13px;
  font-weight: normal;
  margin: 0;
}

.footerContent .footerCompAbout span{
  display: block;
  color:  #ffffff;
  font-size: 14px;
  font-weight: bold;
  margin-bottom: 20px;
}

.footerContent .footerIcons{
  margin-top: 25px;
}

.footerContent .footerIcons a{
  display: inline-block;
  width: 35px;
  height: 35px;
  cursor: pointer;
  background-color:  #33383b;
  border-radius: 2px;

  font-size: 20px;
  color: #ffffff;
  text-align: center;
  line-height: 35px;

  margin-right: 3px;
  margin-bottom: 5px;
}


/***********************************************/

