<template>
  <div>
    <br>
    
    <p>{{message}}</p>
    <p>{{age}}</p>

  </div>
</template>

<script>
export default {
name:"ComponentPractise",
props:{
    message:String,
    age: Number
}
}

</script>

<style>

</style>