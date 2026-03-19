"""
Generate retro art NFT demo layers for the NFTGenerator app.
Creates 5 layers × 15 versions = 75 images in 512x512 PNG format
Also generates the .nftc project file with proper configuration.
"""

from PIL import Image, ImageDraw
import json
import random
import os

# Configuration
BASE_SIZE = 512
LAYER_DIRS = {
    'Background': 'DemoNFTAssets/Retro/Background',
    'Body': 'DemoNFTAssets/Retro/Body',
    'Head': 'DemoNFTAssets/Retro/Head',
    'Accessories': 'DemoNFTAssets/Retro/Accessories',
    'Hat': 'DemoNFTAssets/Retro/Hat'
}

# Retro color palettes
BACKGROUND_COLORS = [
    (25, 25, 112),    # Midnight blue
    (70, 130, 180),   # Steel blue
    (139, 69, 19),    # Brown
    (34, 139, 34),    # Forest green
    (220, 20, 60),    # Crimson
    (72, 61, 139),    # Dark slate blue
    (128, 0, 128),    # Purple
    (255, 165, 0),    # Orange
    (64, 64, 64),     # Dark gray
    (25, 25, 25),     # Near black
    (139, 0, 139),    # Dark magenta
    (0, 100, 100),    # Dark cyan
    (105, 105, 105),  # Dim gray
    (47, 79, 79),     # Dark slate gray
    (75, 0, 130),     # Indigo
]

BODY_COLORS = [
    (255, 192, 203),  # Pink
    (255, 218, 185),  # Peach
    (240, 128, 128),  # Light coral
    (186, 85, 59),    # Brown
    (210, 180, 140),  # Tan
    (233, 150, 122),  # Light salmon
    (255, 228, 181),  # Bisque
    (255, 160, 122),  # Light salmon 2
    (205, 133, 63),   # Peru
    (184, 134, 11),   # Dark goldenrod
    (218, 165, 32),   # Goldenrod
    (188, 143, 143),  # Rosy brown
    (160, 82, 45),    # Sienna
    (139, 90, 43),    # Dark brown
    (255, 140, 0),    # Dark orange
]

HEAD_COLORS = [
    (240, 230, 200),  # Light skin tone
    (222, 184, 135),  # Burlywood
    (210, 180, 140),  # Tan
    (255, 218, 185),  # Peach
    (255, 192, 203),  # Pink
    (230, 190, 160),  # Slightly darker
    (255, 228, 181),  # Bisque
    (255, 200, 150),  # Sandy
    (245, 215, 180),  # Pale
    (220, 200, 170),  # Muted
    (200, 170, 140),  # Warm darker
    (255, 220, 180),  # Light warm
    (235, 205, 175),  # Slightly golden
    (250, 210, 170),  # Peachy
    (228, 198, 168),  # Muted peachy
]

ACCENT_COLORS = [
    (255, 215, 0),    # Gold
    (255, 255, 0),    # Yellow
    (0, 255, 0),      # Lime
    (255, 0, 255),    # Magenta
    (0, 255, 255),    # Cyan
    (255, 69, 0),     # Red-orange
    (50, 205, 50),    # Lime green
    (220, 20, 60),    # Crimson
    (138, 43, 226),   # Blue violet
    (255, 105, 180),  # Hot pink
    (32, 178, 170),   # Light sea green
    (0, 255, 127),    # Spring green
    (255, 140, 0),    # Dark orange
    (199, 21, 133),   # Medium violet red
    (30, 144, 255),   # Dodger blue
]

def draw_pixel_rect(draw, x, y, size, color, pixel_size=8):
    """Draw a pixelated rectangle using the given pixel size."""
    draw.rectangle(
        [x, y, x + size - 1, y + size - 1],
        fill=color,
        outline=None
    )

def draw_background(version):
    """Generate a retro background layer."""
    img = Image.new('RGBA', (BASE_SIZE, BASE_SIZE), (255, 255, 255, 0))
    draw = ImageDraw.Draw(img)
    
    color = BACKGROUND_COLORS[version % len(BACKGROUND_COLORS)]
    
    # Fill background
    draw.rectangle([0, 0, BASE_SIZE - 1, BASE_SIZE - 1], fill=color)
    
    # Add some retro pattern
    pixel_size = 16 + (version % 4) * 8
    pattern_color = tuple(max(0, c - 30) for c in color)
    
    for y in range(0, BASE_SIZE, pixel_size * 2):
        for x in range(0, BASE_SIZE, pixel_size * 2):
            if (x // pixel_size + y // pixel_size) % 2 == 0:
                draw.rectangle(
                    [x, y, x + pixel_size - 1, y + pixel_size - 1],
                    fill=pattern_color
                )
    
    return img

def draw_body(version):
    """Generate a retro body layer."""
    img = Image.new('RGBA', (BASE_SIZE, BASE_SIZE), (255, 255, 255, 0))
    draw = ImageDraw.Draw(img)
    
    color = BODY_COLORS[version % len(BODY_COLORS)]
    outline = (50, 50, 50)
    
    # Draw body shape - rectangular pixelated style
    body_width = 120 + (version % 3) * 20
    body_height = 200 + (version % 3) * 20
    start_x = (BASE_SIZE - body_width) // 2
    start_y = BASE_SIZE // 2 - 40
    
    # Main body
    draw.rectangle(
        [start_x, start_y, start_x + body_width - 1, start_y + body_height - 1],
        fill=color,
        outline=outline,
        width=2
    )
    
    # Arms
    arm_width = 40
    arm_height = 100
    left_arm_x = start_x - arm_width - 10
    right_arm_x = start_x + body_width + 10
    arm_y = start_y + 30
    
    draw.rectangle(
        [left_arm_x, arm_y, left_arm_x + arm_width - 1, arm_y + arm_height - 1],
        fill=color,
        outline=outline,
        width=2
    )
    draw.rectangle(
        [right_arm_x, arm_y, right_arm_x + arm_width - 1, arm_y + arm_height - 1],
        fill=color,
        outline=outline,
        width=2
    )
    
    return img

def draw_head(version):
    """Generate a retro head layer."""
    img = Image.new('RGBA', (BASE_SIZE, BASE_SIZE), (255, 255, 255, 0))
    draw = ImageDraw.Draw(img)
    
    color = HEAD_COLORS[version % len(HEAD_COLORS)]
    outline = (50, 50, 50)
    
    # Head position
    head_size = 100 + (version % 4) * 10
    head_x = (BASE_SIZE - head_size) // 2
    head_y = 60
    
    # Draw head
    draw.rectangle(
        [head_x, head_y, head_x + head_size - 1, head_y + head_size - 1],
        fill=color,
        outline=outline,
        width=2
    )
    
    # Eyes
    eye_size = 12
    left_eye_x = head_x + head_size // 4 - eye_size // 2
    right_eye_x = head_x + 3 * head_size // 4 - eye_size // 2
    eye_y = head_y + head_size // 3
    
    draw.rectangle(
        [left_eye_x, eye_y, left_eye_x + eye_size - 1, eye_y + eye_size - 1],
        fill=(0, 0, 0)
    )
    draw.rectangle(
        [right_eye_x, eye_y, right_eye_x + eye_size - 1, eye_y + eye_size - 1],
        fill=(0, 0, 0)
    )
    
    # Mouth
    mouth_width = head_size // 3
    mouth_x = head_x + head_size // 2 - mouth_width // 2
    mouth_y = head_y + 2 * head_size // 3
    
    draw.rectangle(
        [mouth_x, mouth_y, mouth_x + mouth_width - 1, mouth_y + 8 - 1],
        fill=(200, 0, 0)
    )
    
    return img

def draw_accessories(version):
    """Generate retro accessories layer (glasses, mustache, etc)."""
    img = Image.new('RGBA', (BASE_SIZE, BASE_SIZE), (255, 255, 255, 0))
    draw = ImageDraw.Draw(img)
    
    acc_type = version % 5
    
    if acc_type == 0:  # Glasses
        color = ACCENT_COLORS[version % len(ACCENT_COLORS)]
        # Left lens
        draw.rectangle([150, 120, 190, 160], fill=None, outline=color, width=3)
        # Right lens
        draw.rectangle([290, 120, 330, 160], fill=None, outline=color, width=3)
        # Bridge
        draw.rectangle([188, 130, 292, 150], fill=None, outline=color, width=2)
    
    elif acc_type == 1:  # Mustache
        color = (50, 30, 20)
        # Mustache shape
        draw.polygon(
            [(256, 200), (200, 190), (180, 200), (180, 210), (200, 215), (256, 220),
             (312, 215), (332, 210), (332, 200), (312, 190)],
            fill=color,
            outline=(0, 0, 0)
        )
    
    elif acc_type == 2:  # Monocle
        color = ACCENT_COLORS[version % len(ACCENT_COLORS)]
        draw.ellipse([220, 110, 290, 180], fill=None, outline=color, width=4)
        draw.line([(290, 150), (340, 140)], fill=color, width=3)
    
    elif acc_type == 3:  # Bow tie
        color = ACCENT_COLORS[version % len(ACCENT_COLORS)]
        # Left bow
        draw.polygon([(200, 240), (230, 230), (240, 250), (230, 260)], fill=color)
        # Center
        draw.rectangle([236, 245, 276, 255], fill=color)
        # Right bow
        draw.polygon([(276, 230), (290, 240), (280, 260), (276, 260)], fill=color)
    
    elif acc_type == 4:  # Chains
        color = ACCENT_COLORS[version % len(ACCENT_COLORS)]
        draw.line([(180, 300), (250, 350), (320, 300)], fill=color, width=4)
    
    return img

def draw_hat(version):
    """Generate retro hat layer (various hat styles)."""
    img = Image.new('RGBA', (BASE_SIZE, BASE_SIZE), (255, 255, 255, 0))
    draw = ImageDraw.Draw(img)
    
    hat_type = version % 5
    color = ACCENT_COLORS[version % len(ACCENT_COLORS)]
    
    if hat_type == 0:  # Top hat
        # Crown
        draw.rectangle([180, 20, 330, 90], fill=color, outline=(0, 0, 0), width=2)
        # Brim
        draw.rectangle([150, 85, 355, 110], fill=color, outline=(0, 0, 0), width=2)
    
    elif hat_type == 1:  # Cowboy hat
        # Crown
        draw.polygon(
            [(200, 70), (256, 20), (312, 70), (340, 80), (256, 100), (172, 80)],
            fill=color,
            outline=(0, 0, 0)
        )
        # Brim
        draw.ellipse([140, 95, 372, 130], fill=color, outline=(0, 0, 0), width=2)
    
    elif hat_type == 2:  # Wizard hat
        # Triangle
        draw.polygon(
            [(256, 10), (180, 100), (332, 100)],
            fill=color,
            outline=(0, 0, 0)
        )
        # Decorative band
        draw.rectangle([170, 95, 340, 110], fill=ACCENT_COLORS[(version + 1) % len(ACCENT_COLORS)])
    
    elif hat_type == 3:  # Party hat
        # Cone
        draw.polygon(
            [(256, 10), (210, 85), (302, 85)],
            fill=color,
            outline=(0, 0, 0)
        )
        # Ball on top
        draw.ellipse([250, 5, 262, 17], fill=color, outline=(0, 0, 0), width=1)
    
    elif hat_type == 4:  # Beret
        # Circle
        draw.ellipse([150, 30, 362, 130], fill=color, outline=(0, 0, 0), width=2)
        # Band
        draw.rectangle([170, 125, 342, 140], fill=(50, 50, 50), outline=(0, 0, 0), width=1)
    
    return img

def generate_all_layers():
    """Generate all demo layer images."""
    layers = {
        'Background': draw_background,
        'Body': draw_body,
        'Head': draw_head,
        'Accessories': draw_accessories,
        'Hat': draw_hat,
    }
    
    print("Generating demo NFT layers...")
    total = 0
    
    for layer_name, draw_func in layers.items():
        layer_dir = LAYER_DIRS[layer_name]
        print(f"\nGenerating {layer_name} layers...")
        
        for version in range(15):
            img = draw_func(version)
            filename = f"{layer_name.lower()}{version + 1:02d}.png"
            filepath = os.path.join(layer_dir, filename)
            img.save(filepath, 'PNG')
            print(f"  [OK] Created {filename}")
            total += 1
    
    print(f"\n[SUCCESS] Successfully generated {total} demo layer images!")
    print(f"[INFO] Layers location: DemoNFTAssets/Retro/")

def generate_project_file():
    """Generate the .nftc project file with all layer configurations."""
    
    # Get the absolute path to the DemoNFTAssets directory
    base_path = os.path.abspath('DemoNFTAssets')
    retro_path = os.path.join(base_path, 'Retro')
    
    # Build the layer structure
    overlays = []
    
    # Realm
    realm = {
        "ID": "R1",
        "Name": "Retro",
        "Rarity": 100,
        "RarityPerc": 100.0,
        "LocalPath": retro_path,
        "IsGroup": False,
        "IsRealm": True,
        "Overlays": []
    }
    
    # Define groups with their rarity settings
    groups_config = [
        ("Background", 100),
        ("Body", 100),
        ("Head", 100),
        ("Accessories", 80),
        ("Hat", 60),
    ]
    
    group_id = 1
    for group_name, group_rarity in groups_config:
        group_path = os.path.join(retro_path, group_name)
        group = {
            "ID": f"R1-G{group_id}",
            "Name": group_name,
            "Rarity": group_rarity,
            "RarityPerc": float(group_rarity),
            "LocalPath": group_path,
            "IsGroup": True,
            "IsRealm": False,
            "Overlays": []
        }
        
        # Add layer variations
        for i in range(1, 16):
            img_name = f"{group_name.lower()}{i:02d}.png"
            img_path = os.path.join(group_path, img_name)
            
            # Adjust rarity - later items slightly rarer
            if i <= 13:
                item_rarity = 7
            else:
                item_rarity = 8
            
            layer_item = {
                "ID": f"R1-G{group_id}-I{i}",
                "Name": img_name,
                "Rarity": item_rarity,
                "RarityPerc": round(item_rarity / 105 * 100, 2),  # Normalized percentage
                "LocalPath": img_path,
                "IsGroup": False,
                "IsRealm": False,
                "Overlays": []
            }
            group["Overlays"].append(layer_item)
        
        realm["Overlays"].append(group)
        group_id += 1
    
    overlays.append(realm)
    
    # Create project structure
    project = {
        "ProjectName": "Retro NFT Demo Collection",
        "TotalItems": 100,
        "LastGeneratedJSON": None,
        "Settings": {
            "OutputDirectory": os.path.join(base_path, "..", "output"),
            "OutputSize": "512,512",
            "ResizeAlgorithm": 1,
            "TokenMetaDescription": "Retro pixel art NFT generated by NFT Collection Generator",
            "TokenImageBaseAddress": "ipfs://QmYourImageHash/",
            "TokenMetaBaseAddress": "ipfs://QmYourMetaHash/",
            "HiddenMetaAddress": "ipfs://QmYourHiddenHash/hidden.json",
            "TokenMetaHiddenDescription": "This NFT has not been revealed yet",
            "CollectionRevealed": False,
            "StartTokenID": 0
        },
        "Overlays": overlays
    }
    
    # Save the project file
    project_filename = "Retro_Demo_Project.nftc"
    with open(project_filename, 'w') as f:
        json.dump(project, f, indent=2)
    
    print(f"\n[SUCCESS] Successfully generated project file: {project_filename}")

if __name__ == '__main__':
    generate_all_layers()
    generate_project_file()
