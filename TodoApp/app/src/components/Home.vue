<template>
  <v-app class="grey lighten-4" >
    <v-card class="mx-auto" max-width="400"  >
      <v-img class="white--text align-end" height="200px" :src="image">
        <span class="time">{{ currentTime}}</span>
      </v-img>
      <v-list v-for="task in tasks" :key="task.id">
        <v-list-item>
        <!-- Cool checkbox element from Vuesax framework -->
          <vs-checkbox input-value="active" color="success" v-model="task.done"></vs-checkbox>
          <v-list-item-content>
            <v-list-item-title  >{{task.discription}}</v-list-item-title>
            <!-- <v-text-field v-else v-on:keyup.enter="editTask(task.id)"  :dense="true" :placeholder="task.name"></v-text-field> -->
          </v-list-item-content>
                   <transition name="slide-fade">
            <v-icon v-if="!task.done" @click="task.edit = !task.edit" color="primary" key="pencil">mdi-pencil</v-icon>
            <v-icon v-else @click="deleteTask(task.id)" color="red" key="delete">mdi-delete</v-icon>
          </transition>
          <transition name="slide-fade"></transition>
        </v-list-item>
        <v-divider></v-divider>
      </v-list>
      <v-card-actions></v-card-actions>
    </v-card>
    <input-form></input-form>
   
  </v-app>
  <!-- <v-btn @click="">Hello</v-btn> -->
</template>
  
<script>

import moment from "moment";
import vsCheckbox from "vuesax";
import Vue from "vue";
import "vuesax/dist/vuesax.css";
import InputForm from "./InputForm"
import {mapActions} from 'vuex';
import {mapState} from 'vuex';




Vue.use(vsCheckbox);

export default {
  name: "Home",
   components: {
   InputForm,
  },
  data: () => ({
    
    data: [
      { name: "rado", done: false, id: "1",edit: false },
      { name: "rado2", done: false, id: "2",edit: false },
      { name: "rado3", done: false, id: "3",edit: false }
    ],
    picture: {},
    icons: ["mdi-delete ", "mdi-delete"],
    // tasks: [],

    currentTime: moment(new Date()).format("MMMM Do YYYY"),
    image:
      "https://media.istockphoto.com/photos/to-do-list-on-note-pad-with-coffee-and-pen-on-office-desk-picture-id863607936?k=6&m=863607936&s=612x612&w=0&h=ah7vkAcswYosdcuNZZKaVhmb6P9XSSkozVvhw4K47oM="
      
  }),
 computed: 
   mapState(['tasks']),
 
  methods: {
     ...mapActions(['getData']),
   
    

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
    },
    editTask(task){
      //! apito
      console.log(task);
        //  if (!task === null || task.trim().length > 0) {
        // this.data.push({
        //   name: this.newTask,
        //   done: false,
        //   id: `${this.data.length + 1}`,
        //   edit: false,
        // });
        // this.newTask = "";
      
    }
  },
  created() {
   
   
   this.$store.dispatch('getData')
  
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