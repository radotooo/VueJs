<template>
  <div id="demo">
   
    <button v-on:click="isHidden = !isHidden">Toggle</button>
    <br />
    <transition name="bounce">
      <img :src="imgUrl" v-if="isHidden" />
    </transition>
    <br />
    <div class="container" v-for="(f,index) in fruits" v-bind:key="index">
      <div class="containerIn" v-bind:class="changeFontColor(index)">
        <h1>v-bind:cl{{f.name}}</h1>
        <h2>{{f.age}}</h2>
        <h2>{{index}}</h2>
      </div>
    </div>
    <!-- <h2 @mouseover="isHidden=!isHidden" >Time is ....</h2>
    <div v-if="isHidden"> {{currnetDate}} </div>-->
  </div>
</template>

<script>


export default {
  name: "HelloWorld",
  props: {
    msg: String
  },
   data: () => ({
    imgUrl:
      "https://www.ing.be/assets/nuid/images/uploads/How-to-read-a-URL-video1-en.png",
    isHidden: true,
    resultTest:'',
    currnetDate: new Date(),
    fruits: [
      { id: 1, name: "kiwi", age: 50 },
      { id: 2, name: "kiwi2", age: 52 },
      { id: 3, name: "kiwi3", age: 53 },
      { id: 4, name: "kiwi4", age: 53 },
      { id: 5, name: "kiwi5", age: 53 }
    ]
  }),
  methods: {
    changeFontColor(index) {
      return index % 2 == 0 ? "odd" : "even";
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.containerIn {
  display: inline-block;
  margin: auto;
  padding: 3px;
  background-color: #8ebf42;
}
.container {
  display: inline-block;
  margin: 10px;
}
.odd {
  color: red;
  border: 5px solid black;
  background-color: cornflowerblue;
}
.even {
  color: lightblue;
  background-color: pink;
  border: 5px solid black;
}
.bounce-enter-active {
  animation: bounce-in 0.5s;
}
.bounce-leave-active {
  animation: bounce-in 0.5s reverse;
}
@keyframes bounce-in {
  0% {
    transform: scale(0);
  }
  50% {
    transform: scale(1.5);
  }
  100% {
    transform: scale(1);
  }
}
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
