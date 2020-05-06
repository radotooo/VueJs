<template>
<div class="cotaniner">
  <div>
  <button class="myButton" @click="start()">Test</button>
<p>{{counter}}</p>

</div>

<div class="forma">
  <form @submit.prevent="createImage()">
    <label for="fname">Image Path</label>
    <input   v-model="test1"  type="text" id="fname"  placeholder="Your image path..">

    <label for="lname">Last Name</label>
    <input  type="text" v-model="test2" id="lname"  placeholder="Your image discription..">

    <input type="submit" value="Submit">
  </form>
</div>
<p>{{rado}}</p>
  <div class="gallery" v-for="(image,i) in gallery" v-bind:key="i">
    
      <a class="bb"> 
        <img :src="image.imagePath"  />
      </a>
      <div class="desc">
        <template v-if="image.showDesc" >
          <p>{{image.desc}}</p>
          <button class="show-desc" @click="toggleDescription(image)">Show Less</button>
        </template>
        <template v-else >
          <button @click="toggleDescription(image)"
            class="show-desc"
            
          >Show More</button>
        </template>
        </div>
    
  </div>
</div>
</template>
<script>
export default {
    name:"Test",
    data:()=> ({
    message: 'You loaded this page on ', 
    rado: "test",
    imagePath : "",
    desc:"",
    counter : 60,
    interval:null,
    test2:'',
    test1:'',

    seen : true,
    gallery: [
      { imagePath: 'img/img_5terre.jpg' ,showDesc :false, desc : 'super duper1'},
      {  imagePath: 'img/img_forest.jpg',showDesc :false, desc : 'super duper11' },
      { imagePath: 'img/img_lights.jpg',showDesc :false,desc : 'super duper111' }]
  }),
  methods:{
    toggleDescription(image){
      console.log("hrllo")
      image.showDesc = !image.showDesc 

    } ,
    setRado(e){
      const value = e.target.value
      this.rado=value;

    },
    createImage(){
      this.gallery.push({
        imagePath : this.test1,
        showDesc : false,
        desc : this.test2
        })  
      },
        start() {
      this.interval = setInterval(() => {
        this.counter--;
      }, 1000);
    }
  },
  watch:{
   counter: function(newValue, oldValue) {
      console.log(newValue);
      console.log(oldValue);
      if (newValue === 0) {
        alert('Game has ended!');
        this.counter = 0;
        clearInterval(this.interval);
      }
    }
  }
};
</script>
<style scoped>
.myButton{
  width:60px;
  height:30px;
  font-size: 12px;
  background-color:#008CBA;
  border-radius: 4px;
  transition-duration: 0.4s;
  color: white;

}
.myButton:hover{
  background-color: #4CAF50; /* Green */
  color: white;
}
input[type=text], select {
  width: 20%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

input[type=submit] {
  width: 20%;
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}

input[type=submit]:hover {
  background-color: #45a049;
}

 div.forma {
  border-radius: 5px;
  background-color: #f2f2f2;
  padding: 20px;
} 

#add-item-btn {
  background-color: #008cba;
  color: white;
  padding: 10px 20px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
}
input[type="text"],
textarea {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  box-sizing: border-box;
}
textarea {
  resize: none;
}
div.container {
  margin-right: auto;
  margin-left: auto;
  max-width: 960px;
  padding-right: 10px; /* 3 */
  padding-left: 10px; /* 3 */
}
button.show-desc,
.btn-add {
  background-color: #008cba;
  border: none;
  color: white;
  padding: 10px 20px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
}
button.show-desc.odd {
  background-color: #008cba;
}
button.show-desc.even {
  background-color: red;
}
button.show-desc.decoration {
  border: 5px solid black;
}
div.gallery {
  margin: 5px;
  border: 1px solid #ccc;
  float: left;
  width: 180px;
}
div.gallery:hover {
  border: 1px solid #777;
}
div.gallery img {
  width: 100%;
  height: auto;
}
div.desc {
  padding: 15px;
  text-align: center;
}
</style>
