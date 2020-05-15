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
        <v-row align="center" >
          <v-checkbox 
          name="rado" 
          :label="test" 
          color="success"></v-checkbox>
          
           </v-row>
          <v-divider></v-divider>
          </div>
     
      
      </v-card-text>
     
      <v-card-actions>
 <v-form  >
        
        <v-text-field
                           
                             placeholder="Placeholder"
                           
        ></v-text-field>
        
      </v-form>
      </v-card-actions>
    </v-card>
  </v-app>
</template>
  
<script>
import { mdiPlaylistPlus } from '@mdi/js';

export default {
  name: "Test",
  data: () => ({
    testData: ["rado", "rado2", "rado3"]
  }),
  icon:mdiPlaylistPlus
};
</script>

<style>

</style>