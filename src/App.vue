<template>
  <div id="app">
    <div>
      <img alt="Vue logo" src="./assets/logo.png" />
      <br />
      <CardGame />
      <br />
    </div>
    <div></div>
  </div>
</template>

<script>
import CardGame from "./components/CardGame.vue";

export default {
  name: "App",
  components: {
    CardGame
  }
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
