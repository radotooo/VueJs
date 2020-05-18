<template>
  <v-app>
    <v-card class="mx-auto" max-width="400">
      <v-img
        class="white--text align-end"
        height="200px"
        src="https://source.unsplash.com/1600x900/?nature"
      >
        <v-card-title>Top 10 Australian beaches</v-card-title>
      </v-img>

      <v-card-text class="title">
        <div v-for="(test,i) in testData" :key="i">
          <v-row align="center">
            <v-checkbox name="rado" :label="test" color="success"></v-checkbox>
            <v-icon color="red">{{trash}}</v-icon>
          </v-row>
          <v-divider></v-divider>
        </div>
      </v-card-text>

      <v-card-actions></v-card-actions>
    </v-card>
    <v-row class="pt-3" justify="center">
      <v-form ref="form" align="center">
        <v-text-field
          required
          v-on:keyup.enter="pushTask()"
          style="width:400px"
          v-model="task"
          outlined
          label="Add task"
        ></v-text-field>
      </v-form>
    </v-row>
  </v-app>
</template>
  
<script>
import { mdiDeleteCircle } from "@mdi/js";

export default {
  name: "Test",
  data: () => ({
    testData: ["rado", "rado2", "rado3"],
    task: "",
    trash: mdiDeleteCircle
  }),

  methods: {
    pushTask: function() {
      if (!this.task == "") {
        this.testData.push(this.task);
        this.task = "";
      }
    }
  }
};
</script>

<style>
</style>