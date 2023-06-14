using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "dimension","interface","telescope","algorithm","synergy","platform","treasure","quintessence","emerald","celestial","hydraulic","rhapsody","vertigo","paragon","dulcimer","capricious","gratitude","blueprint","dandelion","obsidian","flamboyant","infinitesimal","turquoise","equilibrium","polarize","maverick","quasar","translucent","satellite","magnificent","carousel","backdrop","engineer","elephant","antelope","rhinoceros","paramount","kinematic","aesthetic","pineapple","cavalier","asterisk","quintet","juggernaut","mosaic","tambourine","kaleidoscope","juxtapose","silverware","terrarium","resonance","benevolent","fascinate","hologram","parabola","dichotomy","iridescent","gingerbread","cardiogram","enterprise","scintillate","saffron","vibrant","surreal","fledgling","harmonize","graphite","chromium","amplifier","tribulation","alabaster","cataclysm","limelight","escalator","apricot","xylophone","metropolis","espionage","wisteria","porcelain","aeronautic","avalanche","oblivion","barracuda","fireplace","longitude","espresso","balcony","radiator","orchestra","crocodile","chameleon","beetroot","impression","waterfall","rainforest","tourniquet","semaphore","revolver","camouflage","abundance","hieroglyph","obscurity","centurion","exponential","silverfish","vertebrate","equinox","corridor","holography","spectacle","ironclad","buttercup","snapdragon","geographer","passageway","innovate","underneath","rejuvenate","shipwreck","magnolia","landscape","freelance","consequence","nightshade","quicksilver","silhouette","retrograde","blossom","fragrance","threshold","butterfly","gentleman","hydroplane","teardrop","carousel","diplomat","carnation","millennium","persistence","transform","porcupine","copperhead","enchantment","relinquish","blackberry","geodesic","moonstone","revolution","asteroid","helicopter","barrister","constellation","archipelago","lighthouse","kaleidoscope","embroidery","imagination","solitaire","cavalryman","chrysanthemum","illuminate","starlight","boulevard","eucalyptus","brilliantine","hieroglyphics","astrolabe","formidable","cherubim","asparagus","brontosaurus","luminescent","pentagonal","saturation","vivacious","blacksmith","astounding","equilateral","thermometer","grapefruit","spectrometer","interpreter","continuum","labyrinth","thermostat","pomegranate","deuterium","wavelength","philanthropy","camellia","carnivorous","innovative","felicitous","anachronism","enlightened","incandescent","tangential","punctuality","concurrence","bittersweet","pantomime","quadrilateral","connoisseur","scaffolding","capillary","spheroidal","radiolarian","multiplicity","reverberate","penultimate","scintillation","abracadabra","triangulate","asymmetrical","kaleidoscopic","malachite","categorize","trigonometry","cosmopolitan","synchronization","metamorphosis","perseverance","adventurous","simultaneously","perspicacious","photovoltaic","surreptitiously","crystalline","photosynthesis","encompassing","unprecedented","demonstration","unobtainable","irreversible","transcendent","contemplative","approximate","equilibrant","opalescent","imperceptible","transformation","unforgettable","inquisitive","reminiscent","reconciliation","trapezoidal","conservation","mesmerizing","astronomical","cylindrical","sensational","incomparable","unbelievable","unconditional","extraordinary","undistinguishable","polychromatic","chrysanthemum","crystallize","breathtaking","xylophonist","conglomerate","periwinkle","butterfinger","antecedent","perspective","hummingbird","therapeutic","complimentary","accommodate","triceratops","electrolyte","heliotrope","aquamarine","indigofera","diplomatic","nomenclature","triathlon","tessellation","incongruity","plethora","anemometer","circumference","binoculars","palindrome","ambassador","quadruplets","pumpernickel","convoluted","stratosphere","mellifluous","hyphenated","calendula","elaborative","cinnamon","compartment","intriguing","equivalence","heliocentric","mandolin","squashbuckler","commensurate","ornamentation","velociraptor","paraphernalia","correspondence","mandrake","calibrate","procrastinate","saxophone","stalagmite","troubadour","barbecue","silversmith","propaganda","manipulate","silkworm","circuitous","annihilation","conservatory","chamberlain","buttercream","underground","compensate","fluorescent","enumeration","pontificate","monochromatic","incorporate","cliffhanger","ambrosia","counterpoint","polarization","accordion","basketball","symmetrical","predator","epitome","counterfeit","silhouette","conglomerate","underestimate","crimson","afterthought","persimmon","magnesium","undertow","bicentennial","blueberry","apocalyptic","deciduous","perseverance","cartographer","symbiosis","formulation","calibration","pathfinder","revolution","procrastinate","hexagonal","metropolitan","kilogram","extrapolate","helix","farsighted","gossamer","evaporate","parallax","anecdote","laboratory","observatory","brilliant","telegraph","decaffeinate","capricorn","parachute","chrysanthemum","effervescence","vagabond","geranium","gladiolus","galaxy","squirrel","strawberry","archaeology","firefly","cappuccino","woodpecker","rhinestone","promenade","baritone","carnelian","catamaran","thermodynamic","jackalope","carpenter","equation","philosophy","watermelon","phenomenon","evangelist","chocolate","handkerchief","buccaneer","buttercream","rejuvenate","landscape","declaration","penumbra","luminary","mistletoe","renaissance","saxophone","zucchini","pulverize","obfuscate","albatross","silhouette","quicksilver","aqueduct","labyrinth","salamander","fluffy","button","marine","mellow","guitar","tulip","butter","planet","purple","rocket","monkey","bright","daisy","sunset","puzzle","forest","sunny","cookie","summer","whale","bubble","jungle","rainbow","spirit","jazz","silky","ocean","coconut","harmony","velvet","parrot","silver","sapphire","dreamer","parade","starry","deluxe","lemon","treasure","blossom","comedy","serene","wizard","captain","marvel","diamond","ribbon","violet","fantasy","celeste","joyful","secret","mystic","rhythm","joyous","breeze","marble","sparkle","charming","silk","sorbet","serenade","giggles","pearl","crimson","aurora","whisper","wonder","truffle","ruffle","lively","kitty","garden","cocoa","sugar","cosmic","glimmer","sweet","cherry","lovely","glitter","luna","sapphire","enchant","star","lucky","carousel","beauty","breeze","twinkle","sunshine","glisten","sunset","whisper","nectar","bloom","bliss","muse","flourish","lullaby","magnolia","magic","chime","delight","emerald","glimpse","honey","petal","playful","raindrop","serenity","shimmer","soothe","velvet","wander","wonder","zephyr","crystal","divine","whimsy","gossamer","harmonize","illuminati","inspire","journey","luminous","paradise","spellbound","tranquil","radiate","bewilder","quaint","cascade","eloquent","serenade","serendipity","serene","delicate","lustrous","resplendent","majestic","enigma","sleek","euphoria","enchanting","melody","evoke","serenade","dazzle","whisper","enrapture","enchant","mesmerize","allure","glow","tranquility","incandescent","opulent","captivate","enigmatic","splendor","glimmer","bliss","ethereal","luminosity","harmonious","scintillating","captivating","rhapsody","magnificent","transcend","celestial","spellbinding","radiant","resonate","brilliant","whimsical","fascinate","sublime","ethereal","mystical","enchant","luminous","splendid","transcendent","inspire","ravishing","mesmerizing","illustrious","effervescent","captivating","exquisite","transfix","glorious","luminous","transcendence","effulgent","enamor","enlighten","evanescent","effulgence","iridescent","wondrous","exhilarating","delightful","surreal","radiance","vivacious","mellifluous","jubilant","stunning","whimsy","efflorescence","transformation","illuminating","transcendental","iridescent","seraphic","resonance","enraptured","enchantress","luminance","glamorous","rapture","wonderment","ethereality","sublimity","inspiration","tranquilize","breathtaking","crystallize", "breathtaking", "xylophonist", "conglomerate", "periwinkle", "butterfinger", "antecedent", "perspective", "hummingbird", "therapeutic", "complimentary", "accommodate", "triceratops", "electrolyte", "heliotrope", "aquamarine", "indigofera", "diplomatic", "nomenclature", "triathlon", "tessellation", "incongruity", "plethora", "anemometer", "circumference", "binoculars", "palindrome", "ambassador", "quadruplets", "pumpernickel", "convoluted", "stratosphere", "mellifluous", "hyphenated", "calendula", "elaborative", "cinnamon", "compartment", "intriguing", "equivalence", "heliocentric", "mandolin", "squashbuckler", "commensurate", "ornamentation", "velociraptor", "paraphernalia", "correspondence", "mandrake", "calibrate", "procrastinate", "saxophone", "stalagmite", "troubadour", "barbecue", "silversmith", "propaganda", "manipulate", "silkworm", "circuitous", "annihilation", "conservatory", "chamberlain", "buttercream", "underground", "compensate", "fluorescent", "enumeration", "pontificate", "monochromatic", "incorporate", "cliffhanger", "ambrosia", "counterpoint", "polarization", "accordion", "basketball", "symmetrical", "predator", "epitome", "counterfeit", "silhouette", "conglomerate", "underestimate", "crimson", "afterthought", "persimmon", "magnesium", "undertow", "bicentennial", "blueberry", "apocalyptic", "deciduous", "perseverance", "cartographer", "symbiosis", "formulation", "calibration", "pathfinder", "revolution", "procrastinate", "hexagonal", "metropolitan", "kilogram", "extrapolate", "helix", "farsighted", "gossamer", "evaporate", "parallax", "anecdote", "laboratory", "observatory", "brilliant", "telegraph", "decaffeinate", "capricorn", "parachute", "chrysanthemum", "effervescence", "vagabond", "geranium", "gladiolus", "galaxy", "squirrel", "strawberry", "archaeology", "firefly", "cappuccino", "woodpecker", "rhinestone", "promenade", "baritone", "carnelian", "catamaran", "thermodynamic", "jackalope", "carpenter", "equation", "philosophy", "watermelon", "phenomenon", "evangelist", "chocolate", "handkerchief", "buccaneer", "buttercream", "rejuvenate", "landscape", "declaration", "penumbra", "luminary", "mistletoe", "renaissance", "saxophone", "zucchini"
    };

    private List<string> workingWords = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
