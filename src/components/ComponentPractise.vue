<template>
  <div>
    <br />

    <p>{{message}}</p>
    <p @click="test()">{{age}}</p>
  </div>
</template>

<script>
export default {
  name: "ComponentPractise",
  props: {
    message: String,
    age: Number
  },
  methods: {
    test() {
      this.$emit("testing", "zdravei");
    }
  }
};
</script>

<style>
</style>