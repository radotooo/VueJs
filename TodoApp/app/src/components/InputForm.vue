<template>
  <v-row class="pt-3" justify="center">
    <v-form align="center">
      <v-text-field
        background-color="white"
        required
        v-on:keyup.enter="pushTaskToData()"
        clearable
        style="width:400px"
        v-model="newTask"
        outlined
        label="Add task"
      ></v-text-field>
    </v-form>
  
  </v-row>
</template>

<script>


export default {
  methods: {
    pushTaskToData: function() {
      var testTask = this.newTask.slice();
      if (!testTask === null || testTask.trim().length > 0) {
        this.data.push({
          name: this.newTask,
          done: false,
          id: `${this.data.length + 1}`,
          edit: false
        });
        this.newTask = "";
      }
    },
    
  }
 
};
</script>

<style>
</style>