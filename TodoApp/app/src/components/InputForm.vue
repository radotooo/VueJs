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

}
</script>

<style>

</style>