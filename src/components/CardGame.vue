 <template>
  <div class="container">
      <ComponentPractise :message="text"  :age='10'/>
      <div v-for="(image,i) in boxes" :key="i">
<div class="flip-card">
  <div class="flip-card-inner">
    <div class="flip-card-front">
      <img :src="image.backSide" alt="Avatar" style="width:200px;height:200px;background-size: cover;">
    </div>
    <div class="flip-card-back">
    <img :src="image.cardFront" alt="Avatar" style="width:200px;height:200px;background-size: cover;">
</div>
    </div>
  </div>
</div>

  </div>
</template>

<script>

import ComponentPractise from './ComponentPractise.vue'

export default {
name:"CardGame",
data:() =>({
  text:"hello",
boxes:
[
    { cardFront:"https://i.stack.imgur.com/zMoo4.jpg", value : 1,backSide:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4f7705ec-8c49-4eed-a56e-c21f3985254c/dah43cy-a8e121cb-934a-40f6-97c7-fa2d77130dd5.png/v1/fill/w_1024,h_1420,strp/pokemon_card_backside_in_high_resolution_by_atomicmonkeytcg_dah43cy-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD0xNDIwIiwicGF0aCI6IlwvZlwvNGY3NzA1ZWMtOGM0OS00ZWVkLWE1NmUtYzIxZjM5ODUyNTRjXC9kYWg0M2N5LWE4ZTEyMWNiLTkzNGEtNDBmNi05N2M3LWZhMmQ3NzEzMGRkNS5wbmciLCJ3aWR0aCI6Ijw9MTAyNCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.6Au-hxTt7FuZ5paCMWMJrAiCi-ClaG35bEG2TgGg0VE"},
    { cardFront:"https://i.stack.imgur.com/zMoo4.jpg", value : 1,backSide:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4f7705ec-8c49-4eed-a56e-c21f3985254c/dah43cy-a8e121cb-934a-40f6-97c7-fa2d77130dd5.png/v1/fill/w_1024,h_1420,strp/pokemon_card_backside_in_high_resolution_by_atomicmonkeytcg_dah43cy-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD0xNDIwIiwicGF0aCI6IlwvZlwvNGY3NzA1ZWMtOGM0OS00ZWVkLWE1NmUtYzIxZjM5ODUyNTRjXC9kYWg0M2N5LWE4ZTEyMWNiLTkzNGEtNDBmNi05N2M3LWZhMmQ3NzEzMGRkNS5wbmciLCJ3aWR0aCI6Ijw9MTAyNCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.6Au-hxTt7FuZ5paCMWMJrAiCi-ClaG35bEG2TgGg0VE"},
    { cardFront:"http://i.imgur.com/tI5jq2c.jpg", value : 2,backSide:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4f7705ec-8c49-4eed-a56e-c21f3985254c/dah43cy-a8e121cb-934a-40f6-97c7-fa2d77130dd5.png/v1/fill/w_1024,h_1420,strp/pokemon_card_backside_in_high_resolution_by_atomicmonkeytcg_dah43cy-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD0xNDIwIiwicGF0aCI6IlwvZlwvNGY3NzA1ZWMtOGM0OS00ZWVkLWE1NmUtYzIxZjM5ODUyNTRjXC9kYWg0M2N5LWE4ZTEyMWNiLTkzNGEtNDBmNi05N2M3LWZhMmQ3NzEzMGRkNS5wbmciLCJ3aWR0aCI6Ijw9MTAyNCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.6Au-hxTt7FuZ5paCMWMJrAiCi-ClaG35bEG2TgGg0VE"},
    { cardFront:"http://i.imgur.com/tI5jq2c.jpg", value : 2,backSide:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4f7705ec-8c49-4eed-a56e-c21f3985254c/dah43cy-a8e121cb-934a-40f6-97c7-fa2d77130dd5.png/v1/fill/w_1024,h_1420,strp/pokemon_card_backside_in_high_resolution_by_atomicmonkeytcg_dah43cy-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD0xNDIwIiwicGF0aCI6IlwvZlwvNGY3NzA1ZWMtOGM0OS00ZWVkLWE1NmUtYzIxZjM5ODUyNTRjXC9kYWg0M2N5LWE4ZTEyMWNiLTkzNGEtNDBmNi05N2M3LWZhMmQ3NzEzMGRkNS5wbmciLCJ3aWR0aCI6Ijw9MTAyNCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.6Au-hxTt7FuZ5paCMWMJrAiCi-ClaG35bEG2TgGg0VE"},
]
    }),
    components:{
        ComponentPractise,
    }

}
</script>



<style>
body {
  font-family: Arial, Helvetica, sans-serif;
}

.flip-card {
  background-color: transparent;
  width: 200px;
  height: 200px;
  perspective: 1000px;
}

.flip-card-inner {
  position: relative;
  width: 100%;
  height: 100%;
  text-align: center;
  transition: transform 0.6s;
  transform-style: preserve-3d;
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
}

.flip-card:hover .flip-card-inner {
  transform: rotateY(180deg);
}

.flip-card-front, .flip-card-back {
  position: absolute;
  width: 100%;
  height: 100%;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.flip-card-front {
  background-color: #bbb;
  color: black;
}

.flip-card-back {
  /* background-color: #2980b9;
  color: white; */
  transform: rotateY(180deg);
}
</style>