<template>
  <v-app class="grey lighten-4">
    <v-card class="mx-auto" max-width="400">
      <v-img class="white--text align-end" height="200px" :src="image">
        <span class="time">{{ currentTime}}</span>
      </v-img>
      <v-list v-for="(task,i) in data" :key="i">
        <v-list-item>
          
          <vs-checkbox input-value="active" color="success" v-model="task.done"></vs-checkbox>
          <v-list-item-content>
            <v-list-item-title :class="addColorAndLineThrough(task.done)">{{task.name}}</v-list-item-title>
          </v-list-item-content>

          <transition name="slide-fade">
            <v-icon v-if="!task.done" color="primary" key="pencil">mdi-pencil</v-icon>
            <v-icon v-else @click="deleteTask(task.id)" color="red" key="delete">mdi-delete</v-icon>
          </transition>

          <transition name="slide-fade"></transition>
        </v-list-item>
        <v-divider></v-divider>
      </v-list>

      <v-card-actions></v-card-actions>
    </v-card>
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
  </v-app>
</template>
  
<script>
import moment from "moment";
import Vuesax from "vuesax";
import Vue from "vue";
import "vuesax/dist/vuesax.css";

Vue.use(Vuesax);

export default {
  name: "Test",
  data: () => ({
    data: [
      { name: "rado", done: false, id: "1" },
      { name: "rado2", done: false, id: "2" },
      { name: "rado3", done: false, id: "3" }
    ],
    picture: {},
    icons: ["mdi-delete ", "mdi-delete"],
    newTask: "",

    currentTime: moment(new Date()).format("MMMM Do YYYY"),
    image:
      "https://media.istockphoto.com/photos/to-do-list-on-note-pad-with-coffee-and-pen-on-office-desk-picture-id863607936?k=6&m=863607936&s=612x612&w=0&h=ah7vkAcswYosdcuNZZKaVhmb6P9XSSkozVvhw4K47oM="
  }),

  methods: {
    pushTaskToData: function() {
      var testTask = this.newTask.slice();
      if (!testTask === null || testTask.trim().length > 0) {
        this.data.push({
          name: this.newTask,
          done: false,
          id: `${this.data.length + 1}`
        });
        this.newTask = "";
      }
    },

    deleteTask(user) {
      var index = this.data.findIndex(x => x.id == user);
      this.data.splice(index, 1);
    },
    addColorAndLineThrough(task) {
      if (task) {
        return ["grey--text", "line-through"];
      } else {
        return "primary--text";
      }
    },
    updateCurrentTime() {
      this.currentTime = moment().format("MMMM Do YYYY");
    }
  },
  created() {
    // fetch(
    //   "https://api.unsplash.com/photos/random?client_id=QJUVikMX1YrBMlMv7wnQPTvCbWYcvBHllt2tM6iivk0&query=quotes"
    // )
    //   .then(response => {
    //     return response.json();
    //   })
    //   .then(data => {
    //     this.picture = data.urls.regular;
    //   });
  }
};
</script>

<style>
.line-through {
  text-decoration: line-through;
}
.slide-fade-enter-active {
  transition: all 0.3s linear;
}
.slide-fade-leave-active {
  transition: all 0.8s cubic-bezier(1, 0.5, 0.8, 1);
}
.slide-fade-enter, .slide-fade-leave-to
/* .slide-fade-leave-active below version 2.1.8 */ {
  transform: translateX(30px);
  opacity: 0;
}
.time {
  margin: 10px;
  color: black;
  font-family: monospace;
  font-weight: bold;
}
</style>